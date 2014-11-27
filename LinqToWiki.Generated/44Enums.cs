// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.querypagepage
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class querypagepage : StringValue
  {
    public static readonly querypagepage Ancientpages = new querypagepage("Ancientpages");
    public static readonly querypagepage BrokenRedirects = new querypagepage("BrokenRedirects");
    public static readonly querypagepage Deadendpages = new querypagepage("Deadendpages");
    public static readonly querypagepage DoubleRedirects = new querypagepage("DoubleRedirects");
    public static readonly querypagepage Listredirects = new querypagepage("Listredirects");
    public static readonly querypagepage Lonelypages = new querypagepage("Lonelypages");
    public static readonly querypagepage Longpages = new querypagepage("Longpages");
    public static readonly querypagepage Mostcategories = new querypagepage("Mostcategories");
    public static readonly querypagepage Mostimages = new querypagepage("Mostimages");
    public static readonly querypagepage Mostinterwikis = new querypagepage("Mostinterwikis");
    public static readonly querypagepage Mostlinkedcategories = new querypagepage("Mostlinkedcategories");
    public static readonly querypagepage Mostlinkedtemplates = new querypagepage("Mostlinkedtemplates");
    public static readonly querypagepage Mostlinked = new querypagepage("Mostlinked");
    public static readonly querypagepage Mostrevisions = new querypagepage("Mostrevisions");
    public static readonly querypagepage Fewestrevisions = new querypagepage("Fewestrevisions");
    public static readonly querypagepage Shortpages = new querypagepage("Shortpages");
    public static readonly querypagepage Uncategorizedcategories = new querypagepage("Uncategorizedcategories");
    public static readonly querypagepage Uncategorizedpages = new querypagepage("Uncategorizedpages");
    public static readonly querypagepage Uncategorizedimages = new querypagepage("Uncategorizedimages");
    public static readonly querypagepage Uncategorizedtemplates = new querypagepage("Uncategorizedtemplates");
    public static readonly querypagepage Unusedcategories = new querypagepage("Unusedcategories");
    public static readonly querypagepage Unusedimages = new querypagepage("Unusedimages");
    public static readonly querypagepage Wantedcategories = new querypagepage("Wantedcategories");
    public static readonly querypagepage Wantedfiles = new querypagepage("Wantedfiles");
    public static readonly querypagepage Wantedpages = new querypagepage("Wantedpages");
    public static readonly querypagepage Wantedtemplates = new querypagepage("Wantedtemplates");
    public static readonly querypagepage Unwatchedpages = new querypagepage("Unwatchedpages");
    public static readonly querypagepage Unusedtemplates = new querypagepage("Unusedtemplates");
    public static readonly querypagepage Withoutinterwiki = new querypagepage("Withoutinterwiki");
    public static readonly querypagepage DisambiguationPages = new querypagepage("DisambiguationPages");
    public static readonly querypagepage DisambiguationPageLinks = new querypagepage("DisambiguationPageLinks");

    internal querypagepage(string value)
      : base(value)
    {
    }

    public static bool operator ==(querypagepage first, querypagepage second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(querypagepage first, querypagepage second)
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
