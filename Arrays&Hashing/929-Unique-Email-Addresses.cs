public class Solution
{
    public int NumUniqueEmails(string[] emails)
    {
        // Dictionary to count valid emails
        Dictionary<string, int> emailsDict = new();
        for (int i = 0; i < emails.Length; i++)
        {
            // Split the email to local name and domain name
            string[] emailSplited = emails[i].Split('@');
            // First part is local name
            string localName= emailSplited[0];
            // Second part is domain name
            string domainName= emailSplited[1];
            // Remove the dots from local name
            localName = localName.Replace(".", string.Empty);
            // trim the part after + sign if exists
            localName = localName.Split("+")[0];
            // Email is now valid after merging the local name and domain name again
            string validEmail = localName + "@" + domainName;
            // Store the email in a dictionary to count

            emailsDict[validEmail] = 1;
        }

        return emailsDict.Count();
    }
}