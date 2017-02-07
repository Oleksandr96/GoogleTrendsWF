using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using MetroFramework.Forms;
using MetroFramework;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace GoogleTrendsWF
{
  public partial class Form1 : MetroForm
  {

    public class Country
    {
      public string Name { get; set; }
      public string RegionCode { get; set; }
      public string Index { get; set; }
    }

    public class City
    {
      public string Latitude { get; set; }
      public string Longitude { get; set; }
      public string Name { get; set; }
      public string Index { get; set; }
    }

    static string getResponse(string uri)
    {
      StringBuilder sb = new StringBuilder();
      byte[] buf = new byte[8192];
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
      HttpWebResponse response = (HttpWebResponse)request.GetResponse();
      Stream resStream = response.GetResponseStream();
      int count = 0;
      do
      {
        count = resStream.Read(buf, 0, buf.Length);
        if (count != 0)
        {
          sb.Append(Encoding.Default.GetString(buf, 0, count));
        }
      }
      while (count > 0);
      return sb.ToString();
    }

    private void GetCountries(string key, string code, string html_code)
    {
      Regex regCountry = new Regex(@"{""country"".*]]");
      MatchCollection matchesCountry = regCountry.Matches(code);
      string resultCountry = "";
      foreach (Match match in matchesCountry)
      {
        string p1 = match.Value;
        resultCountry += p1;
      }
      resultCountry += "}}";
      string json = resultCountry.Replace(@"[""regionCode"",""name"",""Search volume index""],", "");
      JObject JList = JObject.Parse(json);
      JObject JCountry = (JObject)JList["country"];
      JArray CountriesArray = (JArray)JCountry["gvizData"];
      Country C = new Country();
      StringBuilder builder = new StringBuilder();
      builder.Append(html_code);
      var header = string.Format(@"<thead class=""thead-inverse""><tr><th>Region code</th><th>Country name</th><th>Search volume index</th></tr></thead>");
      builder.Append(header);
      foreach (JArray J in CountriesArray)
      {
        C.RegionCode = (string)J[0];
        C.Name = (string)J[1];
        C.Index = (string)J[2];
        var row = string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>", C.RegionCode, C.Name, C.Index);
        builder.Append(row);
      }
      builder.Append("</table></body></html>");
      using (var writer = new StreamWriter(key + " countries results.html"))
      {
        writer.Write(builder.ToString());
      }
      System.Diagnostics.Process.Start(key + " countries results.html");
    }

    private void GetCities(string key, string code, string html_code)
    {
      string codeCity = code.Replace(@",""city"":{""gvizData"":", @",{""city"":{""gvizData"":");
      Regex RegCity = new Regex(@"{""city"".*]]");
      MatchCollection matchesCity = RegCity.Matches(codeCity);
      string resultCity = "";
      foreach (Match match in matchesCity)
      {
        string p1 = match.Value;
        resultCity += p1;
      }
      resultCity += "}}";
      string jsonCity = resultCity.Replace(@"[""lat"",""lng"",""city"",""Search volume index""],", "");
      JObject JListCity = JObject.Parse(jsonCity);
      JObject JCity = (JObject)JListCity["city"];
      JArray CitysArray = (JArray)JCity["gvizData"];
      City City = new City();
      StringBuilder builderCity = new StringBuilder();
      builderCity.Append(html_code);
      var headerCity = string.Format(@"<thead class=""thead-inverse""><tr><th>Latitude</th><th>Longitude</th><th>City name</th><th>Search volume index</th></tr></thead>");
      builderCity.Append(headerCity);
      foreach (JArray J in CitysArray)
      {
        City.Latitude = (string)J[0];
        City.Longitude = (string)J[1];
        City.Name = (string)J[2];
        City.Index = (string)J[3];
        var row = string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td></tr>", City.Latitude, City.Longitude, City.Name, City.Index);
        builderCity.Append(row);
      }
      builderCity.Append("</table></body></html>");

      using (var writer = new StreamWriter(key + " cities results.html"))
      {
        writer.Write(builderCity.ToString());
      }
      System.Diagnostics.Process.Start(key + " cities results.html");
    }

    private void GetTrends(string key, bool country, bool city)
    {
      string url = "http://www.google.com/trends/trendsReport?hl=en&q=" + key.Replace(" ", "%20");
      string code = getResponse(url);
      string html_code = @"<html>   
                            <head>
                                <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha/css/bootstrap.min.css"">
                                <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha/js/bootstrap.min.js""></script>                      
                             </head> 
                             <body STYLE=""background-color: #00cdcd; padding: 30px 200px; ""> 
                             <center><h1>Results for """ + key + @"""</h1></center>   
                             <table STYLE=""background-color: #fff"" class=""table table-hover"" align = ""center"">";
      if (country)
      {
        GetCountries(key, code, html_code);
      }
      if (city)
      {
        GetCities(key, code, html_code);
      }
    }

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      RadioButton1.Checked = true;
    }

    private void searchPictureBox_Click(object sender, EventArgs e)
    {
      try
      {
        if (string.IsNullOrWhiteSpace(InputBox.Text) == true)
        {
          MetroMessageBox.Show(this, "The input line is empty", "Input error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
          if (RadioButton1.Checked == true)
          {
            GetTrends(InputBox.Text, true, true);
          }
          if (RadioButton2.Checked == true)
          {
            GetTrends(InputBox.Text, true, false);
          }
          if (RadioButton3.Checked == true)
          {
            GetTrends(InputBox.Text, false, true);
          }
        }
      }
      catch (Newtonsoft.Json.JsonException)
      {
        MetroMessageBox.Show(this, "Server error. You have asked a lot of requests. Try again later.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      catch (Exception ex)
      {
        MetroMessageBox.Show(this, ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
