using System;

namespace FriendLetter.Models
{
  public class LetterVariable 
  {
    public string Recipient { get; set; }
    public string Sender { get; set; }

    // contructor
    public LetterVariable(string recipient, string sender) {
      Recipient = recipient;
      Sender = sender;
    }

  }
}