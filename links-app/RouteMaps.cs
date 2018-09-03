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
            {"/plus", "https://plus.google.com/u/0/+MichaelMeadowsAndYourMom"},
            {"/cm2017-RAdAC", $"{HomePageRoot}single-post/2018/01/11/CodeMash-2018-RAdAC-Talk"},
            {"/cm2018-RAdAC", $"{HomePageRoot}single-post/2018/01/11/CodeMash-2018-RAdAC-Talk"},
            {"/pres/2018/codemash/socket/slides", "https://docs.google.com/presentation/d/1EDPaVR0mAWGN1mU91vH3pRY5Xrz9MxYzZ0x48eu_LdE/edit?usp=sharing"},
            {"/pres/2018/codemash/socket/code", $"{GitHubRoot}WalkingDisaster/edux/tree/CodeMash2018-edux"},
            {"/cm2018-socket", $"{HomePageRoot}single-post/2018/01/12/CodeMash-2018-SocketIO-Talk"},
            {"/sftodo", $"{HomePageRoot}service-fabric-to-do"},
            {"/sessions", "https://sessionize.com/walkingdisaster"},
        };
    }
}
