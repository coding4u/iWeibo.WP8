using TencentWeiboSDK.Hammock.Web;

namespace TencentWeiboSDK.Hammock.Authentication
{
    public interface IWebCredentials
    {
        WebQuery GetQueryFor(string url, 
                             RestBase request, 
                             IWebQueryInfo info, 
                             WebMethod method);

        WebQuery GetQueryFor(string url,
                             WebParameterCollection parameters,
                             IWebQueryInfo info,
                             WebMethod method);
    }
}