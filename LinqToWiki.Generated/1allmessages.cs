// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.allmessagesWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Collections;
using LinqToWiki.Generated;

namespace LinqToWiki.Generated.Entities
{
  public sealed class allmessagesWhere
  {
    /// <summary>
    /// Which messages to output. "*" (default) means all messages
    /// 
    /// </summary>
    public ItemOrCollection<string> messages { get; private set; }

    /// <summary>
    /// Set to enable parser, will preprocess the wikitext of message
    ///             Will substitute magic words, handle templates etc.
    /// 
    /// </summary>
    public bool enableparser { get; private set; }

    /// <summary>
    /// If set, do not include the content of the messages in the output.
    /// 
    /// </summary>
    public bool nocontent { get; private set; }

    /// <summary>
    /// Also include local messages, i.e. messages that don't exist in the software but do exist as a MediaWiki: page.
    ///             This lists all MediaWiki: pages, so it will also list those that aren't 'really' messages such as Common.js
    /// 
    /// </summary>
    public bool includelocal { get; private set; }

    /// <summary>
    /// Arguments to be substituted into message
    /// 
    /// </summary>
    public ItemOrCollection<string> args { get; private set; }

    /// <summary>
    /// Return only messages with names that contain this string
    /// 
    /// </summary>
    public string filter { get; private set; }

    /// <summary>
    /// Return only messages in this customisation state
    /// 
    /// </summary>
    public allmessagescustomised customised { get; private set; }

    /// <summary>
    /// Return messages in this language
    /// 
    /// </summary>
    public string lang { get; private set; }

    /// <summary>
    /// Return messages starting at this message
    /// 
    /// </summary>
    public string from { get; private set; }

    /// <summary>
    /// Return messages ending at this message
    /// 
    /// </summary>
    public string to { get; private set; }

    /// <summary>
    /// Page name to use as context when parsing message (for enableparser option)
    /// 
    /// </summary>
    public string title { get; private set; }

    /// <summary>
    /// Return messages with this prefix
    /// 
    /// </summary>
    public string prefix { get; private set; }

    private allmessagesWhere()
    {
    }
  }
}
