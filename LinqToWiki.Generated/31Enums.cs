// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.allusersgroup
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class allusersgroup : StringValue
  {
    public static readonly allusersgroup bot = new allusersgroup("bot");
    public static readonly allusersgroup sysop = new allusersgroup("sysop");
    public static readonly allusersgroup bureaucrat = new allusersgroup("bureaucrat");
    public static readonly allusersgroup reviewer = new allusersgroup("reviewer");
    public static readonly allusersgroup autoreview = new allusersgroup("autoreview");
    public static readonly allusersgroup steward = new allusersgroup("steward");
    public static readonly allusersgroup accountcreator = new allusersgroup("accountcreator");
    public static readonly allusersgroup import = new allusersgroup("import");
    public static readonly allusersgroup transwiki = new allusersgroup("transwiki");
    public static readonly allusersgroup ipblock_exempt = new allusersgroup("ipblock-exempt");
    public static readonly allusersgroup oversight = new allusersgroup("oversight");
    public static readonly allusersgroup founder = new allusersgroup("founder");
    public static readonly allusersgroup rollbacker = new allusersgroup("rollbacker");
    public static readonly allusersgroup confirmed = new allusersgroup("confirmed");
    public static readonly allusersgroup autoreviewer = new allusersgroup("autoreviewer");
    public static readonly allusersgroup researcher = new allusersgroup("researcher");
    public static readonly allusersgroup filemover = new allusersgroup("filemover");
    public static readonly allusersgroup checkuser = new allusersgroup("checkuser");
    public static readonly allusersgroup abusefilter = new allusersgroup("abusefilter");
    public static readonly allusersgroup afttest = new allusersgroup("afttest");
    public static readonly allusersgroup afttest_hide = new allusersgroup("afttest-hide");
    public static readonly allusersgroup epcoordinator = new allusersgroup("epcoordinator");
    public static readonly allusersgroup eponline = new allusersgroup("eponline");
    public static readonly allusersgroup epcampus = new allusersgroup("epcampus");
    public static readonly allusersgroup epinstructor = new allusersgroup("epinstructor");

    internal allusersgroup(string value)
      : base(value)
    {
    }

    public static bool operator ==(allusersgroup first, allusersgroup second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(allusersgroup first, allusersgroup second)
    {
      return !object.Equals((object) first, (object) second);
    }

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }
}
