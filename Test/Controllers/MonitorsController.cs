using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace Test.Controllers
{
	public class MonitorsController : ApiController
    {
		public IHttpActionResult GetMonitors()
		{
			var jsonResponse = "{\"content\": {\"search_id\": 1,\"ref\": \"1495711341‐Tu51KL9s\",\"is_monitored\": true,\"monitors\": [{\"monitored_by\": 1,\"updated_at\": \"2015-06-18 09:35:06\",\"created_at\": \"2015-06-11 15:02:30\"},{\"monitored_by\": 1,\"updated_at\": \"2015-06-18 09:35:06\",\"created_at\": \"2015-06-11 15:02:30\"}]},\"status\": \"success\"}";

			var jss = new JavaScriptSerializer();
			var json = jss.Deserialize<dynamic>(jsonResponse);

			var monitors = json["content"]["monitors"];
			List<Monitors> Monitors = new List<Monitors>();

			foreach (var monitor in monitors)
			{
				Monitors.Add(
				  new Monitors()
				  {
					  MonitoredBy = monitor["monitored_by"],
					  UpdatedAt = DateTime.Parse(monitor["updated_at"]),
					  CreatedAt = DateTime.Parse(monitor["created_at"])
				  }
				);
			}

			var results = new Content()
			{
				SearchId = json["content"]["search_id"],
				Ref = json["content"]["ref"],
				IsMonitored = json["content"]["is_monitored"],
				Monitors = Monitors
			};

			return Ok(results);
		}


		public class Content
		{
			public int SearchId { get; set; }
			public string Ref { get; set; }
			public bool IsMonitored { get; set; }
			public List<Monitors> Monitors { get; set; }
		}

		public class Monitors
		{
			public int MonitoredBy { get; set; }
			public DateTime UpdatedAt { get; set; }
			public DateTime CreatedAt { get; set; }
		}
	}
}
