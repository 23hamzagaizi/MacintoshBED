using System;
using System.ComponentModel.DataAnnotations; 
namespace MacintoshBED.Models 
public class Message
{
	public Message()
	{
		[Key]
		public int IdMessage { get; set; }
		public int IdFrom { get; set; }
		public int IdTo { get; set; }
		public string Message { get; set; }
	}
}
