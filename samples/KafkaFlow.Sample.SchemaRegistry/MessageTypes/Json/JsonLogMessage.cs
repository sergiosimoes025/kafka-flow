namespace SchemaRegistry
{
	using Newtonsoft.Json;

	/// <summary>
	/// A simple log message.
	/// </summary>
	public class JsonLogMessage
	{
		[JsonProperty]
		public string Message { get; set; }
		
		[JsonProperty]
		public string Type { get; set; }
	}
}
