using WalkingDisaster.Links.Domain;

namespace WalkingDisaster.Links;

public static class RouteMaps
{
    private const string HomePageRoot = "https://www.michaelmeadows.com/";
    private const string GitHubRoot = "https://github.com/WalkingDisaster/";
    private const string GoogleDrive = "https://docs.google.com/";

    private static readonly IDictionary<string, object> Routes = new Dictionary<string, object>
    {
        // Top Level Routes
        ["GitHub"] = new SimpleRoute("/github", $"{GitHubRoot}"),
        ["LinkedIn"] = new SimpleRoute("/linkedin", "https://www.linkedin.com/in/michaelnmeadows/"),
        ["Blog"] = new SimpleRoute("/blog", $"{HomePageRoot}blog"),
        ["Sessionize"] = new SimpleRoute("/sessions", "https://sessionize.com/walkingdisaster"),
        ["Insight"] = new SimpleRoute("/insight", "https://insight.com"),
        ["Insight DI"] =
            new SimpleRoute("/insightdi", "https://www.insight.com/en_US/what-we-do/digital-innovation.html"),
        ["Venmo"] = new SimpleRoute("/venmo", "https://venmo.com/code?user_id=2794062025326592415"),
        ["All Sessions"] = new SimpleRoute("/allsessions",
            "https://www.michaelmeadows.com/post/all-my-sessions-are-belong-to-you"),

        // Shared Links
        ["/l/baguette"] = new SimpleRoute("/l/baguette", "https://www.youtube.com/watch?v=IRDL3lPQSkc"),
        ["disneyhack"] = new SimpleRoute("disneyhack", "https://github.com/devanshithakar12/WhatTheHack/tree/066-v2.1/066-OpenAIFundamentals/Coach"),

        // GitHub Projects
        ["EDUX"] = new SimpleRoute("/proj/edux", $"{GitHubRoot}edux/tree/stirtrek2017"),

        // Conferences
        ["2017 - Stir Trek"] = new ConferenceSession(
            "stirtrek", 2017, $"{HomePageRoot}single-post/presentations/2017/stirtrek-resources",
            $"{GoogleDrive}presentation/d/1T0iYRul6NdwM6GpE-jDuQBD13kFspxiXXXlwDQKOwpM/edit?usp=sharing",
            $"{GitHubRoot}edux/tree/stirtrek2017",
            null
        ),
        ["2018 - Code Mash - RADAC"] = new ConferenceSession(
            "codemash/radac", 2018, $"{HomePageRoot}single-post/2018/01/11/CodeMash-2018-RAdAC-Talk",
            $"{GitHubRoot}/CodeMash2018-RAdAC/tree/master/Slides",
            $"{GitHubRoot}/CodeMash2018-RAdAC", null
        ),
        ["2018 - Code Mash - SocketIO"] = new ConferenceSession(
            "codemash/socket", 2018, $"{HomePageRoot}single-post/2018/01/12/CodeMash-2018-SocketIO-Talk",
            $"{GoogleDrive}presentation/d/1EDPaVR0mAWGN1mU91vH3pRY5Xrz9MxYzZ0x48eu_LdE/edit?usp=sharing",
            $"{GitHubRoot}edux/tree/CodeMash2018-edux",
            null
        ),
        ["2019 - MTC"] = new ConferenceSession(
            "mtc", 2019, $"{HomePageRoot}single-post/2019/01/30/MTC-Detroit-2019", null, null, null
        ),
        ["2019 - COAzure - Cosmos DB"] = new ConferenceSession(
            "coazure/cosmos", 2019, $"{HomePageRoot}single-post/2019/COAzure/CosmosDB",
            $"{GoogleDrive}presentation/d/1vCzaGZgkSbHs9NflCrOsHoxxGupA09mmybErunCzXFw/edit?usp=sharing",
            $"{GitHubRoot}cosmosdb-demo", null
        ),
        ["2019 - Stir Trek"] = new ConferenceSession(
            "stirtrek", 2019, $"{HomePageRoot}single-post/2019/stir-trek",
            $"{GoogleDrive}presentation/d/1hxydNML8S0PSCzkvtz8V0Kgvsu2MKZ1qDtKaSPQKpRM/edit?usp=sharing",
            null,
            "https://youtu.be/HghDNdXg9CU"
        ),
        ["2019 - COAzure - Distributed Architectures"] = new ConferenceSession(
            "coazure/dist", 2019,
            $"{GoogleDrive}presentation/d/1oIg8C_HbwWC06d6DPeYn9Zt3P7b6t-T5XVZClPECtMg/edit?usp=sharing",
            null, null, null
        ),
        ["2020 - Code PaLouSa"] = new ConferenceSession(
            "codepalousa", 2020, $"{HomePageRoot}post/code-palousa-2020",
            "https://drive.google.com/file/d/1feicLdvohFk9-KOcuevFCt49BbLPDZl1/view?usp=sharing",
            null,
            "https://www.youtube.com/watch?v=yjNgV-xj65M"
        ),
        ["2023 - Stir Trek"] = new ConferenceSession(
            "stirtrek", 2023, $"{HomePageRoot}post/stir-trek-2023",
            "https://drive.google.com/drive/folders/1w4YbtxQaelRu4QO7bTmjww6-yo-yQr8t?usp=share_link",
            null,
            "https://www.youtube.com/watch?v=Z_-1cRPptDA&t"
        )
    };

    public static WebApplication? MapRoutesFromData(this WebApplication? app)
    {
        if (app == null)
        {
            return app;
        }

        var routes = new List<SimpleRoute>();
        foreach (var (key, routeCandidate) in Routes)
        {
            switch (routeCandidate)
            {
                case SimpleRoute route:
                    app.MapGet(route.Path, () => Results.Redirect(route.RedirectUrl, true))
                        .WithTags("Simple Routes");
                    break;
                case ConferenceSession route:
                {
                    var path = $"/s/{route.Year:####}/{route.Conference}";
                    app.MapGet(path, () => Results.Redirect(route.BaseUrl, true))
                        .WithTags("Conference Sessions", $"{route.Year} Sessions", key);
                    if (route.CodeUrl != null)
                    {
                        var codePath = $"/s/{route.Year:####}/{route.Conference}/code";
                        app.MapGet(codePath, () => Results.Redirect(route.CodeUrl))
                            .WithTags("Session Code", key);
                    }

                    if (route.SlidesUrl != null)
                    {
                        var slidesPath = $"/s/{route.Year:####}/{route.Conference}/slides";
                        app.MapGet(slidesPath, () => Results.Redirect(route.SlidesUrl))
                            .WithTags("Session Slides", key);
                    }

                    if (route.VideoUrl != null)
                    {
                        var videoPath = $"/s/{route.Year:####}/{route.Conference}/video";
                        app.MapGet(videoPath, () => Results.Redirect(route.VideoUrl))
                            .WithTags("Session Videos", key);
                    }

                    break;
                }
                default:
                    throw new InvalidOperationException("Unknown Route Type");
            }
        }
        
        app.MapGet("/{*_}", () => Results.Redirect(HomePageRoot));

        return app;
    }
}
