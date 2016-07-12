# webapi-actionvaluebinder-nodatime

This repo is for wiring up web api (or mvc) to use nodatime through model binding. Currently only instants are supported. Feel free to add more if you wish

example usage:
```public void Configure(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);

            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();

            config.ConfigureNodatimeWebApi();

            config.EnsureInitialized();
}```
