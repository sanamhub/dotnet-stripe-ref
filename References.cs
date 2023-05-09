using Stripe;

namespace StripeRef;

internal static class References
{
    public static async Task InvokeAsync()
    {
        await AuthenticationAsync();
    }

    // Authentication with Stripe.Net
    private static async Task AuthenticationAsync()
    {
        // globally set api key
        //StripeConfiguration.ApiKey = "";
        //var service = new CustomerService();
        //var customers = await service.ListAsync();
        //var customer = await service.GetAsync("cus_???");
        //Console.WriteLine(customers);
        //Console.WriteLine("--------------------------");
        //Console.WriteLine(customer);

        // per request api key
        //var service = new CustomerService();
        //var requestOptions = new RequestOptions
        //{
        //    ApiKey = ""
        //};
        //var customer = await service.GetAsync("cus_???", null, requestOptions);
        //Console.WriteLine(customer);

        // with stripe connect
        StripeConfiguration.ApiKey = "";
        var service = new CustomerService();
        var requestOptions = new RequestOptions
        {
            StripeAccount = "sasa",
        };
        var customer = await service.GetAsync("cus_???", null, requestOptions);
        Console.WriteLine(customer);
    }
}
