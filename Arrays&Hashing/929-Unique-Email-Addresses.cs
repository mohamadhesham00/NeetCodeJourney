public class Solution
{
    public int NumUniqueEmails(string[] emails)
    {
        Dictionary<string, int> emailsDict = new();
        for (int i = 0; i < emails.Length; i++)
        {
            string[] emailSplited = emails[i].Split('@');
            string localName= emailSplited[0];
            string domainName= emailSplited[1];
            localName = localName.Replace(".", string.Empty);
            localName = localName.Split("+")[0];
            string validEmail = localName + "@" + domainName;
            emailsDict[validEmail] = 1;
        }

        return emailsDict.Count();
    }
}