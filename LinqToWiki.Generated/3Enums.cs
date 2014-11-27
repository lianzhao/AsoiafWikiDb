// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.editcontentformat
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class editcontentformat : StringValue
  {
    public static readonly editcontentformat text_x_wiki = new editcontentformat("text/x-wiki");
    public static readonly editcontentformat text_javascript = new editcontentformat("text/javascript");
    public static readonly editcontentformat text_css = new editcontentformat("text/css");
    public static readonly editcontentformat text_plain = new editcontentformat("text/plain");
    public static readonly editcontentformat application_json = new editcontentformat("application/json");

    internal editcontentformat(string value)
      : base(value)
    {
    }

    public static bool operator ==(editcontentformat first, editcontentformat second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(editcontentformat first, editcontentformat second)
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
