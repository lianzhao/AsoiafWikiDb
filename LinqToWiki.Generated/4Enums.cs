// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.editcontentmodel
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class editcontentmodel : StringValue
  {
    public static readonly editcontentmodel wikitext = new editcontentmodel("wikitext");
    public static readonly editcontentmodel javascript = new editcontentmodel("javascript");
    public static readonly editcontentmodel css = new editcontentmodel("css");
    public static readonly editcontentmodel text = new editcontentmodel("text");
    public static readonly editcontentmodel JsonZeroConfig = new editcontentmodel("JsonZeroConfig");
    public static readonly editcontentmodel Scribunto = new editcontentmodel("Scribunto");
    public static readonly editcontentmodel JsonSchema = new editcontentmodel("JsonSchema");

    internal editcontentmodel(string value)
      : base(value)
    {
    }

    public static bool operator ==(editcontentmodel first, editcontentmodel second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(editcontentmodel first, editcontentmodel second)
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
