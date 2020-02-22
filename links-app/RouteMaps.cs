using System.Collections.Generic;

namespace links_app
{
    public static class RouteMaps
    {
        internal const string HomePageRoot = "https://www.michaelmeadows.com/";
        private const string GitHubRoot = "https://github.com/WalkingDisaster/";
        private const string GoogleDrive = "https://docs.google.com/";

        public static IDictionary<string, string> Routes = new Dictionary<string, string>
        {
            {"/github", $"{GitHubRoot}"},
            {"/linkedin", "https://www.linkedin.com/in/michaelnmeadows/"},
            {"/plus", "https://plus.google.com/+MichaelMeadows3f"},

            {"/blog", $"{HomePageRoot}blog"},            
            {"/sessions", "https://sessionize.com/walkingdisaster"},
            {"/sftodo", $"{HomePageRoot}service-fabric-to-do"},

            {"/proj/edux", $"{GitHubRoot}edux/tree/stirtrek2017"},
            {"/st2017", $"{HomePageRoot}single-post/presentations/2017/stirtrek-resources"},
            {"/pres/2017/stirtrek/slides", $"{GoogleDrive}presentation/d/1T0iYRul6NdwM6GpE-jDuQBD13kFspxiXXXlwDQKOwpM/edit?usp=sharing"},
            {"/pres/2017/stirtrek/edux", $"{GitHubRoot}edux/tree/stirtrek2017"},
            {"/cm2017-RAdAC", $"{HomePageRoot}single-post/2018/01/11/CodeMash-2018-RAdAC-Talk"},
            {"/cm2018-RAdAC", $"{HomePageRoot}single-post/2018/01/11/CodeMash-2018-RAdAC-Talk"},
            {"/pres/2018/codemash/socket/slides", $"{GoogleDrive}presentation/d/1EDPaVR0mAWGN1mU91vH3pRY5Xrz9MxYzZ0x48eu_LdE/edit?usp=sharing"},
            {"/pres/2018/codemash/socket/code", $"{GitHubRoot}edux/tree/CodeMash2018-edux"},
            {"/cm2018-socket", $"{HomePageRoot}single-post/2018/01/12/CodeMash-2018-SocketIO-Talk"},
            {"/troll", "http://glench.com/hash/#diy.800.Max%5CnMax%5CnMax%5CnGreschl%5CnGreschl%5CnGreschl%5Cnis%5Cna%5CnGinger%5Cn%5CnGinger%5Cn%5CnGinger%5Cn%5CnGinger%5Cn"},
            {"/insight", $"https://insight.com"},
            {"/483", $"https://photos.app.goo.gl/vbX4Yijhov1EuVok8"},
            
            {"/mtcdet1", "https://www.michaelmeadows.com/single-post/2019/01/30/MTC-Detroit-2019"},
            {"/pres/2019/mtc/micro-arch", "https://docs.microsoft.com/en-us/azure/architecture/microservices/"},
            
            {"/aha", "http://www2.heart.org/site/TR?fr_id=3995&pg=personal&px=8328769&s_hasSecureSession=true"},
            {"/pres/2019/coazure/cosmos", "https://www.michaelmeadows.com/single-post/2019/COAzure/CosmosDB"},
            
            {"/st19", $"{HomePageRoot}single-post/2019/stir-trek"},
            {"/go/st19/v", "https://youtu.be/HghDNdXg9CU"},
            {"/pres/2019/stir-trek/slides", $"{GoogleDrive}presentation/d/1hxydNML8S0PSCzkvtz8V0Kgvsu2MKZ1qDtKaSPQKpRM/edit?usp=sharing"},
            {"/go/build19", "https://docs.google.com/presentation/d/1hBgb_e7YjmNO9dgD1efeGfhFUjX2jhq-tmkjqyipJCk/edit?usp=sharing"},
            
            {"/go/here", "https://drive.google.com/open?id=1WS3LgWJVW5jl87MfEwGo8p37WwIX_IA1"},
            {"/go/a8d20", "https://drive.google.com/open?id=1TukAWKZt8VK3qLCO1z50KNIPcmB5_MCy"},
            {"/venmo", "https://venmo.com/code?user_id=2794062025326592415"},
            {"/files/40c3a", "https://meadowsfiles.blob.core.windows.net/40c3a3636/77b1de01-b0ee-49c1-ab2f-dde957f76d10.pdf?sp=r&st=2020-02-22T20:07:21Z&se=2020-02-24T20:07:21Z&spr=https&sv=2019-02-02&sr=b&sig=swkbm9NQ%2F09%2BXsAzvEyUF7BPkzR2PVvz%2BKInz%2F0qu%2FA%3D"},
        };
    }
}
