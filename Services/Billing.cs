using Grpc.Core;
using Billing;

namespace BillingService;
public class BillingService : Billing.Billing.BillingBase
{
    // Add while adding new user
    static int TotalRating = 6800;
    static SortedList<int, UserProfile> users = new SortedList<int, UserProfile>()
    {
      {5000,new UserProfile(){Name = "boris"}},
      {1000,new UserProfile(){Name = "maria"}},
      {800,new UserProfile(){Name = "oleg"}}
    };
    static List<Coin> Coins = new List<Coin>();

    private readonly ILogger<BillingService> _logger;
    public BillingService(ILogger<BillingService> logger)
    {
        _logger = logger;
    }

    public override async Task ListUsers(None request, IServerStreamWriter<UserProfile> responseStream, ServerCallContext context)
    {
        foreach (var item in users)
        {
            await responseStream.WriteAsync(item.Value);
        }
    }
    int[] GetCoinsPerUsers(long Amount)
    {

        int[] CoinsPerUser = new int[users.Count];
        int i = 0, sum = 0;
        foreach (var item in users)
        {
            CoinsPerUser[i] = (int)Math.Round((item.Key / (double)TotalRating * Amount), MidpointRounding.AwayFromZero);
            sum += CoinsPerUser[i];
            i++;
        }
        i--;
        while (sum > Amount && i != -1)
        {
            CoinsPerUser[i]--;
            i--;
            sum -= 1;
        }
        while (sum < Amount && i != -1)
        {
            CoinsPerUser[i]++;
            i--;
            sum += 1;
        }
        return CoinsPerUser;
    }
    public override Task<Response> CoinsEmission(EmissionAmount request, ServerCallContext context)
    {
        if (request.Amount <= 0)
          return Task.FromResult(new Response() { Status = Response.Types.Status.Failed, Comment = "Недействительная сумма" });
        if (request.Amount < users.Count)
          return Task.FromResult(new Response() { Status = Response.Types.Status.Failed, Comment = "Недостаточно монет для эмиссии" });

        int i = 0;
        int[] CoinsPerUser = GetCoinsPerUsers(request.Amount);
        Random R = new Random();

        foreach (var item in users)
        {
            item.Value.Amount += CoinsPerUser[i];
            for (int j = 0; j < CoinsPerUser[i]; j++)
                Coins.Add(new Coin()
                {
                    Id = R.NextInt64(0, long.MaxValue),
                    History = item.Value.Name + ' '
                });

            i++;
        }

        return Task.FromResult(new Response() { Status = Response.Types.Status.Ok });

    }
    public override Task<Response> MoveCoins(MoveCoinsTransaction request, ServerCallContext context)
    {

        UserProfile SrcUser = users.First((KeyValuePair<int, UserProfile> KV) => KV.Value.Name == request.SrcUser).Value;

        if (SrcUser.Amount < request.Amount)
            return Task.FromResult(new Response() { Status = Response.Types.Status.Failed, Comment = "Недостаточно средств" });

        UserProfile DstUser = users.First((KeyValuePair<int, UserProfile> KV) => KV.Value.Name == request.DstUser).Value;



        SrcUser.Amount -= request.Amount;
        DstUser.Amount += request.Amount;

        int i = 0;
        foreach (var item in Coins.Where((Coin c) => c.History.EndsWith($"{SrcUser.Name} ")))
        {
            if (i >= request.Amount)
                break;
            item.History += DstUser.Name + ' ';
            i++;
        }

        return Task.FromResult(new Response() { Status = Response.Types.Status.Ok });
    }
    public override Task<Coin> LongestHistoryCoin(None request, ServerCallContext context)
    {
        Coin Max = null;
        int MaxHistoryLen = 0, CurrentHistoryLen;
        foreach (var item in Coins)
        {
            CurrentHistoryLen = item.History.Count(c => c == ' ');
            if (CurrentHistoryLen > MaxHistoryLen)
            {
                MaxHistoryLen = CurrentHistoryLen;
                Max = item;
            }
        }
        return Task.FromResult(Max);
    }


}


