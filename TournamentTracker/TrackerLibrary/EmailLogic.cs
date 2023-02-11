using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Configuration;
using System.Net.Configuration;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class EmailLogic
    {
        public static void SendEmail(string to, string subject, string body)
        {
            MailAddress fromAddress = new MailAddress(GlobalConfig.senderEmailAddress);
            MailAddress toAddress = new MailAddress(to);
            MailMessage mail = new MailMessage();
            mail.From = fromAddress;
            mail.To.Add(toAddress);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            SmtpClient clien = new SmtpClient();
            clien.Send(mail);
        }
        public static void AlertUserToNewRound(TournamentModel t)
        {
            int currentRound = TournamentLogic.CheckCurrentRound(t);
            List<MatchupModel> r = t.Rounds.Where(x => x.First().MatchupRound == currentRound).First();
            foreach (MatchupModel m in r)
            {
                foreach (MatchupEntryModel me in m.Entries)
                {
                    foreach (PersonModel p in me.TeamCompeting.TeamMembers)
                    {
                        AlertPersonToNewRound(p,
                            m.Entries.Where(x => x.TeamCompeting != me.TeamCompeting).FirstOrDefault());
                    }
                }
            }
        }
        private static void AlertPersonToNewRound(PersonModel p, MatchupEntryModel competitor)
        {
            string to;
            string subject;
            string body;
            StringBuilder sb = new StringBuilder();

            if (competitor != null)
            {
                subject = $"You have a new match with {competitor.TeamCompeting.TeamName}";
                sb.AppendLine("<h1>You have a new matchup</h1>");
                sb.Append("<strong>Cometitor: </strong>");
                sb.Append(competitor.TeamCompeting.TeamName);
                sb.AppendLine(); sb.AppendLine(); sb.AppendLine();
                sb.AppendLine("Have a great time!");
                sb.AppendLine("From: Tournament Tracker Email Center");
            }
            else
            {
                subject = "You have a bye week this round";
                sb.AppendLine("Enjoy your day off!");
                sb.AppendLine(); sb.AppendLine(); sb.AppendLine();
                sb.AppendLine("Have a great time!");
                sb.AppendLine("From: Tournament Tracker Email Center");
            }
            body = sb.ToString();
            to = p.EmailAddress;
            EmailLogic.SendEmail(to, subject, body);
        }
    }
}
