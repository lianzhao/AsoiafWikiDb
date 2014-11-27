// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.logeventstype
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class logeventstype : StringValue
  {
    public static readonly logeventstype none = new logeventstype("");
    public static readonly logeventstype block = new logeventstype("block");
    public static readonly logeventstype protect = new logeventstype("protect");
    public static readonly logeventstype rights = new logeventstype("rights");
    public static readonly logeventstype delete = new logeventstype("delete");
    public static readonly logeventstype upload = new logeventstype("upload");
    public static readonly logeventstype move = new logeventstype("move");
    public static readonly logeventstype import = new logeventstype("import");
    public static readonly logeventstype patrol = new logeventstype("patrol");
    public static readonly logeventstype merge = new logeventstype("merge");
    public static readonly logeventstype suppress = new logeventstype("suppress");
    public static readonly logeventstype review = new logeventstype("review");
    public static readonly logeventstype stable = new logeventstype("stable");
    public static readonly logeventstype spamblacklist = new logeventstype("spamblacklist");
    public static readonly logeventstype gblblock = new logeventstype("gblblock");
    public static readonly logeventstype renameuser = new logeventstype("renameuser");
    public static readonly logeventstype globalauth = new logeventstype("globalauth");
    public static readonly logeventstype gblrights = new logeventstype("gblrights");
    public static readonly logeventstype abusefilter = new logeventstype("abusefilter");
    public static readonly logeventstype articlefeedbackv5 = new logeventstype("articlefeedbackv5");
    public static readonly logeventstype pagetriage_curation = new logeventstype("pagetriage-curation");
    public static readonly logeventstype pagetriage_deletion = new logeventstype("pagetriage-deletion");
    public static readonly logeventstype institution = new logeventstype("institution");
    public static readonly logeventstype course = new logeventstype("course");
    public static readonly logeventstype student = new logeventstype("student");
    public static readonly logeventstype online = new logeventstype("online");
    public static readonly logeventstype campus = new logeventstype("campus");
    public static readonly logeventstype instructor = new logeventstype("instructor");
    public static readonly logeventstype thanks = new logeventstype("thanks");
    public static readonly logeventstype newusers = new logeventstype("newusers");

    internal logeventstype(string value)
      : base(value)
    {
    }

    public static bool operator ==(logeventstype first, logeventstype second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(logeventstype first, logeventstype second)
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
