using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace links_app
{
    public static class RouteMaps
    {
        private const string HomePageRoot = "https://www.michaelmeadows.com/";
        private const string GitHubRoot = "https://github.com/WalkingDisaster/";
        private const string GoogleDrive = "https://docs.google.com/";

        private static readonly IDictionary<string, string> Routes = new Dictionary<string, string>
        {
            // Sessions
            // /s/yyyy/conf-name
            // /s/yyyy/conf-name/slides
            // /s/yyyy/conf-name/code
            // /s/yyyy/conf-name/video
            // {"/cm2017-RAdAC", $"{HomePageRoot}single-post/2018/01/11/CodeMash-2018-RAdAC-Talk"},
            // {"/cm2018-RAdAC", $"{HomePageRoot}single-post/2018/01/11/CodeMash-2018-RAdAC-Talk"},
            // {"/sftodo", $"{HomePageRoot}service-fabric-to-do"},
            //{
            //    "/pres/2018/codemash/socket/slides",
            //    $"{GoogleDrive}presentation/d/1EDPaVR0mAWGN1mU91vH3pRY5Xrz9MxYzZ0x48eu_LdE/edit?usp=sharing"
            //},
            //{"/pres/2018/codemash/socket/code", $"{GitHubRoot}edux/tree/CodeMash2018-edux"},
            //{"/cm2018-socket", $"{HomePageRoot}single-post/2018/01/12/CodeMash-2018-SocketIO-Talk"},
            // {"/mtcdet1", "https://www.michaelmeadows.com/single-post/2019/01/30/MTC-Detroit-2019"},
            // {"/pres/2019/coazure/cosmos", "https://www.michaelmeadows.com/single-post/2019/COAzure/CosmosDB"},

            // {"/st19", $"{HomePageRoot}single-post/2019/stir-trek"},
            // {"/go/st19/v", "https://youtu.be/HghDNdXg9CU"},
            // {
            //     "/pres/2019/stir-trek/slides",
            //     $"{GoogleDrive}presentation/d/1hxydNML8S0PSCzkvtz8V0Kgvsu2MKZ1qDtKaSPQKpRM/edit?usp=sharing"
            // },
            // {
            //     "/go/coazure/2019",
            //     "https://docs.google.com/presentation/d/1oIg8C_HbwWC06d6DPeYn9Zt3P7b6t-T5XVZClPECtMg/edit?usp=sharing"
            // },
            // {"/go/cp20", "https://www.michaelmeadows.com/post/code-palousa-2020"},
            // {"/go/cp20slides", "https://drive.google.com/file/d/1feicLdvohFk9-KOcuevFCt49BbLPDZl1/view?usp=sharing"},

            // Files
            {
                "/files/40c3a",
                "https://meadowsfiles.blob.core.windows.net/40c3a3636/77b1de01-b0ee-49c1-ab2f-dde957f76d10.pdf?sp=r&st=2020-02-22T20:07:21Z&se=2020-02-24T20:07:21Z&spr=https&sv=2019-02-02&sr=b&sig=swkbm9NQ%2F09%2BXsAzvEyUF7BPkzR2PVvz%2BKInz%2F0qu%2FA%3D"
            },

            // Shared Links
            {"/l/baguette", "https://www.youtube.com/watch?v=IRDL3lPQSkc"}
        };

        private static readonly
            IEnumerable<(string conference, int year, string baseUrl, string slidesUrl, string codeUrl, string videoUrl)
            > ConferenceSessions = new[]
            {
                // 2017
                (
                    "stirtrek", 2017, $"{HomePageRoot}single-post/presentations/2017/stirtrek-resources",
                    $"{GoogleDrive}presentation/d/1T0iYRul6NdwM6GpE-jDuQBD13kFspxiXXXlwDQKOwpM/edit?usp=sharing",
                    $"{GitHubRoot}edux/tree/stirtrek2017",
                    (string) null
                ),

                // 2018
                (
                    "codemash/radac", 2018, $"{HomePageRoot}single-post/2018/01/11/CodeMash-2018-RAdAC-Talk",
                    $"{GitHubRoot}/CodeMash2018-RAdAC/tree/master/Slides",
                    $"{GitHubRoot}/CodeMash2018-RAdAC", null
                ),
                (
                    "codemash/socket", 2018, $"{HomePageRoot}single-post/2018/01/12/CodeMash-2018-SocketIO-Talk",
                    $"{GoogleDrive}presentation/d/1EDPaVR0mAWGN1mU91vH3pRY5Xrz9MxYzZ0x48eu_LdE/edit?usp=sharing",
                    $"{GitHubRoot}edux/tree/CodeMash2018-edux",
                    null
                ),

                // 2019
                (
                    "mtc", 2019, $"{HomePageRoot}single-post/2019/01/30/MTC-Detroit-2019", null, null, null
                ),
                (
                    "coazure/cosmos", 2019, $"{HomePageRoot}single-post/2019/COAzure/CosmosDB",
                    $"{GoogleDrive}presentation/d/1vCzaGZgkSbHs9NflCrOsHoxxGupA09mmybErunCzXFw/edit?usp=sharing",
                    $"{GitHubRoot}cosmosdb-demo", null
                ),
                (
                    "stirtrek", 2019, $"{HomePageRoot}single-post/2019/stir-trek",
                    $"{GoogleDrive}presentation/d/1hxydNML8S0PSCzkvtz8V0Kgvsu2MKZ1qDtKaSPQKpRM/edit?usp=sharing",
                    null,
                    "https://youtu.be/HghDNdXg9CU"
                ),
                (
                    "coazure/dist", 2019,
                    $"{GoogleDrive}presentation/d/1oIg8C_HbwWC06d6DPeYn9Zt3P7b6t-T5XVZClPECtMg/edit?usp=sharing",
                    null, null, null
                ),

                // 2020
                (
                    "codepalousa", 2020, $"{HomePageRoot}post/code-palousa-2020",
                    "https://drive.google.com/file/d/1feicLdvohFk9-KOcuevFCt49BbLPDZl1/view?usp=sharing",
                    null,
                    "https://www.youtube.com/watch?v=yjNgV-xj65M"
                ),
            
                // 2023
                (
                    "stirtrek", 2023, $"{HomePageRoot}post/stir-trek-2023",
                    "https://drive.google.com/drive/folders/1w4YbtxQaelRu4QO7bTmjww6-yo-yQr8t?usp=share_link",
                    null,
                    null
                )
            };

        private static readonly IEnumerable<(string route, string url)> TopLevelRoutes = new[]
        {
            ("/github", $"{GitHubRoot}"),
            ("/linkedin", "https://www.linkedin.com/in/michaelnmeadows/"),
            ("/blog", $"{HomePageRoot}blog"),
            ("/sessions", "https://sessionize.com/walkingdisaster"),
            ("/insight", "https://insight.com"),
            ("/insightdi", "https://www.insight.com/en_US/what-we-do/digital-innovation.html"),
            ("/venmo", "https://venmo.com/code?user_id=2794062025326592415"),
            ("/allsessions", "https://www.michaelmeadows.com/post/all-my-sessions-are-belong-to-you")
        };

        private static readonly IEnumerable<(string nickname, string url)> ProjectLinks = new[]
        {
            ("edux", $"{GitHubRoot}edux/tree/stirtrek2017")
        };

        public static void UseMappedRoutes(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                foreach (var route in TopLevelRoutes)
                    endpoints.MapGet(route.route, context => DefineRoute(context, route.url));
                foreach (var route in ProjectLinks)
                    endpoints.MapGet($"/proj/{route.nickname}", context => DefineRoute(context, route.url));
                foreach (var route in ConferenceSessions)
                {
                    endpoints.MapGet($"/s/{route.year:####}/{route.conference}",
                        context => DefineRoute(context, route.baseUrl));
                    Console.WriteLine(route.baseUrl);
                    // Console.WriteLine(
                    //     $"Created route for conference: /s/{route.year:####}/{route.conference} => {route.baseUrl}");

                    if (route.codeUrl != null)
                    {
                        endpoints.MapGet($"/s/{route.year:####}/{route.conference}/code",
                            context => DefineRoute(context, route.codeUrl));
                        // Console.WriteLine(
                        //     $"Created route for conference: /s/{route.year:####}/{route.conference}/code => {route.codeUrl}");
                    }

                    if (route.slidesUrl != null)
                    {
                        endpoints.MapGet($"/s/{route.year:####}/{route.conference}/slides",
                            context => DefineRoute(context, route.slidesUrl));
                        // Console.WriteLine(
                        //     $"Created route for conference: /s/{route.year:####}/{route.conference}/slides => {route.slidesUrl}");
                    }

                    if (route.videoUrl != null)
                    {
                        endpoints.MapGet($"/s/{route.year:####}/{route.conference}/video",
                            context => DefineRoute(context, route.videoUrl));
                        // Console.WriteLine(
                        //     $"Created route for conference: /s/{route.year:####}/{route.conference}/video => {route.videoUrl}");
                    }
                }

                foreach (var route in Routes) endpoints.MapGet(route.Key, context => DefineRoute(context, route.Value));
                endpoints.MapFallback(context => DefineRoute(context, HomePageRoot));
            });
        }

        private static async Task DefineRoute(HttpContext context, string url)
        {
            context.Response.Redirect(url);
            context.Response.Headers.Add("Cache-Control", "no-cache, no-store");
            context.Response.Headers.Add("Expires", "-1");
            await context.Response.WriteAsync("");
        }
    }
}
