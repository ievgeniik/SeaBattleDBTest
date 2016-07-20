using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using Facebook;
using Newtonsoft.Json.Linq;

namespace FacebookFriendsInfo
{
    public partial class FacebookSync : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Authentication();
        }

        private void Authentication()
        {
            string appID = "153888201687769";
            string appSecret = "2a4a59b396e8c2dbed126b9a742b5fbb";
            string scope = "user_friends";

            if (Request["code"] == null)
            {
                Response.Redirect(string.Format("https://graph.facebook.com/oauth/authorize?client_id={0}&redirect_uri={1}&scope={2}", 
                    appID, Request.Url.AbsoluteUri, scope));
            }
            else
            {
                Dictionary<string, string> tokens = new Dictionary<string, string>();

                string url = string.Format("https://graph.facebook.com/oauth/access_token?client_id={0}&redirect_uri={1}&scope={2}&code={3}&client_secret={4}", 
                    appID, Request.Url.AbsoluteUri, scope, Request["code"].ToString(), appSecret);

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());

                    string vals = reader.ReadToEnd();

                    foreach (string token in vals.Split('&'))
                    {
                        tokens.Add(token.Substring(0, token.IndexOf("=")), 
                            token.Substring(token.IndexOf("=") + 1, token.Length - token.IndexOf("=") - 1));
                    }
                }

                string accessToken = tokens["access_token"];

                FacebookClient client = new FacebookClient(accessToken);

                var friendListData = client.Get("/me/friends");
                JObject friendListJson = JObject.Parse(friendListData.ToString());

                //List<FBUser> fbUsers = new List<FBUser>();
                //foreach (var friend in friendListJson["data"].Children())
                //{
                //    FBUser fbUser = new FBUser();
                //    fbUser.Id = friend["id"].ToString().Replace("\"", "");
                //    fbUser.Name = friend["name"].ToString().Replace("\"", "");
                //    fbUsers.Add(fbUser);
                //}

                //string q = null;
            }
        }
    }
}