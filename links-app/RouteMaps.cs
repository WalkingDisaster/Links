using System.Collections.Generic;

namespace links_app
{
    public static class RouteMaps
    {
        internal const string HomePageRoot = "https://www.michaelmeadows.com/";
        private const string GitHubRoot = "https://github.com/WalkingDisaster/";

        public static IDictionary<string, string> Routes = new Dictionary<string, string>
        {
            {"/github", $"{GitHubRoot}"},
            {"/blog", $"{HomePageRoot}blog"},
            {"/proj/edux", $"{GitHubRoot}edux/tree/stirtrek2017"},

            {"/st2017", $"{HomePageRoot}single-post/presentations/2017/stirtrek-resources"},
            {"/pres/2017/stirtrek/slides", "https://docs.google.com/presentation/d/1T0iYRul6NdwM6GpE-jDuQBD13kFspxiXXXlwDQKOwpM/edit?usp=sharing"},
            {"/pres/2017/stirtrek/edux", $"{GitHubRoot}edux/tree/stirtrek2017"},
            {"/plus", "https://plus.google.com/u/0/+MichaelMeadowsAndYourMom" },
            {"/cm2017-RAdAC", "https://www.michaelmeadows.com/single-post/2018/01/11/CodeMash-2018-RAdAC-Talk" }
        };
    }
}
