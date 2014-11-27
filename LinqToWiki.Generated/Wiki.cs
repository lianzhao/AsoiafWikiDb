// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Wiki
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Generated.Entities;
using LinqToWiki.Internals;
using LinqToWiki.Parameters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace LinqToWiki.Generated
{
  public sealed class Wiki
  {
    private static readonly QueryTypeProperties<blockResult> blockProperties = new QueryTypeProperties<blockResult>("block", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "block"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, blockResult>(blockResult.Parse));
    private static readonly QueryTypeProperties<compareResult> compareProperties = new QueryTypeProperties<compareResult>("compare", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "compare"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, compareResult>(compareResult.Parse));
    private static readonly QueryTypeProperties<object> createaccountProperties = new QueryTypeProperties<object>("createaccount", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "createaccount"
      }
    }, (IDictionary<string, string[]>) null, (Func<XElement, object>) (_ => (object) null));
    private static readonly QueryTypeProperties<deleteResult> deleteProperties = new QueryTypeProperties<deleteResult>("delete", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "delete"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, deleteResult>(deleteResult.Parse));
    private static readonly QueryTypeProperties<deleteglobalaccountResult> deleteglobalaccountProperties = new QueryTypeProperties<deleteglobalaccountResult>("deleteglobalaccount", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "deleteglobalaccount"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, deleteglobalaccountResult>(deleteglobalaccountResult.Parse));
    private static readonly QueryTypeProperties<editResult> editProperties = new QueryTypeProperties<editResult>("edit", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "edit"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, editResult>(editResult.Parse));
    private static readonly QueryTypeProperties<emailuserResult> emailuserProperties = new QueryTypeProperties<emailuserResult>("emailuser", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "emailuser"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, emailuserResult>(emailuserResult.Parse));
    private static readonly QueryTypeProperties<expandtemplatesResult> expandtemplatesProperties = new QueryTypeProperties<expandtemplatesResult>("expandtemplates", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "expandtemplates"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, expandtemplatesResult>(expandtemplatesResult.Parse));
    private static readonly QueryTypeProperties<filerevertResult> filerevertProperties = new QueryTypeProperties<filerevertResult>("filerevert", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "filerevert"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, filerevertResult>(filerevertResult.Parse));
    private static readonly QueryTypeProperties<importResult> importProperties = new QueryTypeProperties<importResult>("import", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "import"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, importResult>(importResult.Parse));
    private static readonly QueryTypeProperties<loginResult> loginProperties = new QueryTypeProperties<loginResult>("login", "lg", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "login"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, loginResult>(loginResult.Parse));
    private static readonly QueryTypeProperties<object> logoutProperties = new QueryTypeProperties<object>("logout", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "logout"
      }
    }, (IDictionary<string, string[]>) null, (Func<XElement, object>) (_ => (object) null));
    private static readonly QueryTypeProperties<moveResult> moveProperties = new QueryTypeProperties<moveResult>("move", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "move"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, moveResult>(moveResult.Parse));
    private static readonly QueryTypeProperties<optionsResult> optionsProperties = new QueryTypeProperties<optionsResult>("options", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "options"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, optionsResult>(optionsResult.Parse));
    private static readonly QueryTypeProperties<patrolResult> patrolProperties = new QueryTypeProperties<patrolResult>("patrol", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "patrol"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, patrolResult>(patrolResult.Parse));
    private static readonly QueryTypeProperties<protectResult> protectProperties = new QueryTypeProperties<protectResult>("protect", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "protect"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, protectResult>(protectResult.Parse));
    private static readonly QueryTypeProperties<purgeResult> purgeProperties = new QueryTypeProperties<purgeResult>("purge", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "purge"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, purgeResult>(purgeResult.Parse));
    private static readonly QueryTypeProperties<rollbackResult> rollbackProperties = new QueryTypeProperties<rollbackResult>("rollback", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "rollback"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, rollbackResult>(rollbackResult.Parse));
    private static readonly QueryTypeProperties<setglobalaccountstatusResult> setglobalaccountstatusProperties = new QueryTypeProperties<setglobalaccountstatusResult>("setglobalaccountstatus", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "setglobalaccountstatus"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, setglobalaccountstatusResult>(setglobalaccountstatusResult.Parse));
    private static readonly QueryTypeProperties<setnotificationtimestampResult> setnotificationtimestampProperties = new QueryTypeProperties<setnotificationtimestampResult>("setnotificationtimestamp", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "setnotificationtimestamp"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, setnotificationtimestampResult>(setnotificationtimestampResult.Parse));
    private static readonly QueryTypeProperties<tokensResult> tokensProperties = new QueryTypeProperties<tokensResult>("tokens", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "tokens"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, tokensResult>(tokensResult.Parse));
    private static readonly QueryTypeProperties<unblockResult> unblockProperties = new QueryTypeProperties<unblockResult>("unblock", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "unblock"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, unblockResult>(unblockResult.Parse));
    private static readonly QueryTypeProperties<undeleteResult> undeleteProperties = new QueryTypeProperties<undeleteResult>("undelete", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "undelete"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, undeleteResult>(undeleteResult.Parse));
    private static readonly QueryTypeProperties<uploadResult> uploadProperties = new QueryTypeProperties<uploadResult>("upload", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "upload"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, uploadResult>(uploadResult.Parse));
    private static readonly QueryTypeProperties<watchResult> watchProperties = new QueryTypeProperties<watchResult>("watch", "", new QueryType?(), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "watch"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, watchResult>(watchResult.Parse));
    private readonly WikiInfo m_wiki;

    public QueryAction Query { get; private set; }

    public int PagesSourcePageSize
    {
      get
      {
        return this.m_wiki.PagesSourcePageSize;
      }
      set
      {
        this.m_wiki.PagesSourcePageSize = value;
      }
    }

    public Wiki(string userAgent, string baseUri = null, string apiPath = null)
    {
      this.m_wiki = new WikiInfo(userAgent, baseUri ?? "http://en.wikipedia.org", apiPath ?? "/w/api.php", (IEnumerable<Namespace>) null);
      this.Query = new QueryAction(this.m_wiki);
    }

    public PagesSource<Page> CreateTitlesSource(IEnumerable<string> titles)
    {
      return (PagesSource<Page>) new TitlesSource<Page>(this.m_wiki, titles);
    }

    public PagesSource<Page> CreateTitlesSource(params string[] titles)
    {
      return (PagesSource<Page>) new TitlesSource<Page>(this.m_wiki, (IEnumerable<string>) titles);
    }

    public PagesSource<Page> CreatePageIdsSource(IEnumerable<long> pageIds)
    {
      return (PagesSource<Page>) new PageIdsSource<Page>(this.m_wiki, pageIds);
    }

    public PagesSource<Page> CreatePageIdsSource(params long[] pageIds)
    {
      return (PagesSource<Page>) new PageIdsSource<Page>(this.m_wiki, (IEnumerable<long>) pageIds);
    }

    public PagesSource<Page> CreateRevIdsSource(IEnumerable<long> revIds)
    {
      return (PagesSource<Page>) new RevIdsSource<Page>(this.m_wiki, revIds);
    }

    public PagesSource<Page> CreateRevIdsSource(params long[] revIds)
    {
      return (PagesSource<Page>) new RevIdsSource<Page>(this.m_wiki, (IEnumerable<long>) revIds);
    }

    /// <summary>
    /// Block a user
    /// 
    /// </summary>
    /// <param name="user">Username, IP address or IP range you want to block
    ///             </param><param name="token">A block token previously obtained through prop=info
    ///             </param><param name="expiry">Relative expiry time, e.g. '5 months' or '2 weeks'. If set to 'infinite', 'indefinite' or 'never', the block will never expire.
    ///             </param><param name="reason">Reason for block
    ///             </param><param name="anononly">Block anonymous users only (i.e. disable anonymous edits for this IP)
    ///             </param><param name="nocreate">Prevent account creation
    ///             </param><param name="autoblock">Automatically block the last used IP address, and any subsequent IP addresses they try to login from
    ///             </param><param name="noemail">Prevent user from sending email through the wiki. (Requires the "blockemail" right.)
    ///             </param><param name="hidename">Hide the username from the block log. (Requires the "hideuser" right.)
    ///             </param><param name="allowusertalk">Allow the user to edit their own talk page (depends on $wgBlockAllowsUTEdit)
    ///             </param><param name="reblock">If the user is already blocked, overwrite the existing block
    ///             </param><param name="watchuser">Watch the user/IP's user and talk pages
    ///             </param>
    public blockResult block(string user, string token = null, string expiry = null, string reason = null, bool? anononly = null, bool? nocreate = null, bool? autoblock = null, bool? noemail = null, bool? hidename = null, bool? allowusertalk = null, bool? reblock = null, bool? watchuser = null)
    {
      QueryParameters<blockResult, blockResult> parameters = QueryParameters.Create<blockResult>().AddSingleValue("user", QueryRepresentation.ToQueryString(user));
      if (token != null)
        parameters = parameters.AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (expiry != null)
        parameters = parameters.AddSingleValue("expiry", QueryRepresentation.ToQueryString(expiry));
      if (reason != null)
        parameters = parameters.AddSingleValue("reason", QueryRepresentation.ToQueryString(reason));
      if (anononly.HasValue)
        parameters = parameters.AddSingleValue("anononly", QueryRepresentation.ToQueryString(anononly.Value));
      if (nocreate.HasValue)
        parameters = parameters.AddSingleValue("nocreate", QueryRepresentation.ToQueryString(nocreate.Value));
      if (autoblock.HasValue)
        parameters = parameters.AddSingleValue("autoblock", QueryRepresentation.ToQueryString(autoblock.Value));
      if (noemail.HasValue)
        parameters = parameters.AddSingleValue("noemail", QueryRepresentation.ToQueryString(noemail.Value));
      if (hidename.HasValue)
        parameters = parameters.AddSingleValue("hidename", QueryRepresentation.ToQueryString(hidename.Value));
      if (allowusertalk.HasValue)
        parameters = parameters.AddSingleValue("allowusertalk", QueryRepresentation.ToQueryString(allowusertalk.Value));
      if (reblock.HasValue)
        parameters = parameters.AddSingleValue("reblock", QueryRepresentation.ToQueryString(reblock.Value));
      if (watchuser.HasValue)
        parameters = parameters.AddSingleValue("watchuser", QueryRepresentation.ToQueryString(watchuser.Value));
      return new QueryProcessor<blockResult>(this.m_wiki, Wiki.blockProperties).ExecuteSingle<blockResult>(parameters);
    }

    /// <summary>
    /// Get the difference between 2 pages
    ///             You must pass a revision number or a page title or a page ID id for each part (1 and 2)
    /// 
    /// </summary>
    /// <param name="fromtitle">First title to compare
    ///             </param><param name="fromid">First page ID to compare
    ///             </param><param name="fromrev">First revision to compare
    ///             </param><param name="totitle">Second title to compare
    ///             </param><param name="toid">Second page ID to compare
    ///             </param><param name="torev">Second revision to compare
    ///             </param>
    public compareResult compare(string fromtitle = null, long? fromid = null, int? fromrev = null, string totitle = null, long? toid = null, int? torev = null)
    {
      QueryParameters<compareResult, compareResult> parameters = QueryParameters.Create<compareResult>();
      if (fromtitle != null)
        parameters = parameters.AddSingleValue("fromtitle", QueryRepresentation.ToQueryString(fromtitle));
      if (fromid.HasValue)
        parameters = parameters.AddSingleValue("fromid", QueryRepresentation.ToQueryString(fromid.Value));
      if (fromrev.HasValue)
        parameters = parameters.AddSingleValue("fromrev", QueryRepresentation.ToQueryString(fromrev.Value));
      if (totitle != null)
        parameters = parameters.AddSingleValue("totitle", QueryRepresentation.ToQueryString(totitle));
      if (toid.HasValue)
        parameters = parameters.AddSingleValue("toid", QueryRepresentation.ToQueryString(toid.Value));
      if (torev.HasValue)
        parameters = parameters.AddSingleValue("torev", QueryRepresentation.ToQueryString(torev.Value));
      return new QueryProcessor<compareResult>(this.m_wiki, Wiki.compareProperties).ExecuteSingle<compareResult>(parameters);
    }

    /// <summary>
    /// Create a new user account.
    /// 
    /// </summary>
    /// <param name="name">Username
    ///             </param><param name="password">Password (ignored if mailpassword is set)
    ///             </param><param name="domain">Domain for external authentication (optional)
    ///             </param><param name="token">Account creation token obtained in first request
    ///             </param><param name="email">Email address of user (optional)
    ///             </param><param name="realname">Real name of user (optional)
    ///             </param><param name="mailpassword">If set to any value, a random password will be emailed to the user
    ///             </param><param name="reason">Optional reason for creating the account to be put in the logs
    ///             </param><param name="language">Language code to set as default for the user (optional, defaults to content language)
    ///             </param>
    public void createaccount(string name, string password = null, string domain = null, string token = null, string email = null, string realname = null, bool? mailpassword = null, string reason = null, string language = null)
    {
      QueryParameters<object, object> parameters = QueryParameters.Create<object>().AddSingleValue("name", QueryRepresentation.ToQueryString(name));
      if (password != null)
        parameters = parameters.AddSingleValue("password", QueryRepresentation.ToQueryString(password));
      if (domain != null)
        parameters = parameters.AddSingleValue("domain", QueryRepresentation.ToQueryString(domain));
      if (token != null)
        parameters = parameters.AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (email != null)
        parameters = parameters.AddSingleValue("email", QueryRepresentation.ToQueryString(email));
      if (realname != null)
        parameters = parameters.AddSingleValue("realname", QueryRepresentation.ToQueryString(realname));
      if (mailpassword.HasValue)
        parameters = parameters.AddSingleValue("mailpassword", QueryRepresentation.ToQueryString(mailpassword.Value));
      if (reason != null)
        parameters = parameters.AddSingleValue("reason", QueryRepresentation.ToQueryString(reason));
      if (language != null)
        parameters = parameters.AddSingleValue("language", QueryRepresentation.ToQueryString(language));
      new QueryProcessor<object>(this.m_wiki, Wiki.createaccountProperties).ExecuteSingle<object>(parameters);
    }

    /// <summary>
    /// Delete a page
    /// 
    /// </summary>
    /// <param name="token">A delete token previously retrieved through prop=info
    ///             </param><param name="title">Title of the page you want to delete. Cannot be used together with pageid
    ///             </param><param name="pageid">Page ID of the page you want to delete. Cannot be used together with title
    ///             </param><param name="reason">Reason for the deletion. If not set, an automatically generated reason will be used
    ///             </param><param name="watchlist">Unconditionally add or remove the page from your watchlist, use preferences or do not change watch
    ///             </param><param name="oldimage">The name of the old image to delete as provided by iiprop=archivename
    ///             </param>
    public deleteResult delete(string token, string title = null, long? pageid = null, string reason = null, deletewatchlist watchlist = null, string oldimage = null)
    {
      QueryParameters<deleteResult, deleteResult> parameters = QueryParameters.Create<deleteResult>().AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (title != null)
        parameters = parameters.AddSingleValue("title", QueryRepresentation.ToQueryString(title));
      if (pageid.HasValue)
        parameters = parameters.AddSingleValue("pageid", QueryRepresentation.ToQueryString(pageid.Value));
      if (reason != null)
        parameters = parameters.AddSingleValue("reason", QueryRepresentation.ToQueryString(reason));
      if (watchlist != (deletewatchlist) null)
        parameters = parameters.AddSingleValue("watchlist", QueryRepresentation.ToQueryString((StringValue) watchlist));
      if (oldimage != null)
        parameters = parameters.AddSingleValue("oldimage", QueryRepresentation.ToQueryString(oldimage));
      return new QueryProcessor<deleteResult>(this.m_wiki, Wiki.deleteProperties).ExecuteSingle<deleteResult>(parameters);
    }

    /// <summary>
    /// Delete a global user.
    /// 
    /// </summary>
    /// <param name="user">User to delete.
    ///             </param><param name="token">Your token (obtained from action=tokens&amp;type=deleteglobalaccount).
    ///             </param><param name="reason">Reason for deleting the user.
    ///             </param>
    public deleteglobalaccountResult deleteglobalaccount(string user, string token, string reason = null)
    {
      QueryParameters<deleteglobalaccountResult, deleteglobalaccountResult> parameters = QueryParameters.Create<deleteglobalaccountResult>().AddSingleValue("user", QueryRepresentation.ToQueryString(user)).AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (reason != null)
        parameters = parameters.AddSingleValue("reason", QueryRepresentation.ToQueryString(reason));
      return new QueryProcessor<deleteglobalaccountResult>(this.m_wiki, Wiki.deleteglobalaccountProperties).ExecuteSingle<deleteglobalaccountResult>(parameters);
    }

    /// <summary>
    /// Create and edit pages.
    /// 
    /// </summary>
    /// <param name="token">Edit token. You can get one of these through prop=info.
    ///             The token should always be sent as the last parameter, or at least, after the text parameter
    ///             </param><param name="title">Title of the page you want to edit. Cannot be used together with pageid
    ///             </param><param name="pageid">Page ID of the page you want to edit. Cannot be used together with title
    ///             </param><param name="section">Section number. 0 for the top section, 'new' for a new section
    ///             </param><param name="sectiontitle">The title for a new section
    ///             </param><param name="text">Page content
    ///             </param><param name="summary">Edit summary. Also section title when section=new and sectiontitle is not set
    ///             </param><param name="minor">Minor edit
    ///             </param><param name="notminor">Non-minor edit
    ///             </param><param name="bot">Mark this edit as bot
    ///             </param><param name="basetimestamp">Timestamp of the base revision (obtained through prop=revisions&amp;rvprop=timestamp).
    ///             Used to detect edit conflicts; leave unset to ignore conflicts
    ///             </param><param name="starttimestamp">Timestamp when you obtained the edit token.
    ///             Used to detect edit conflicts; leave unset to ignore conflicts
    ///             </param><param name="recreate">Override any errors about the article having been deleted in the meantime
    ///             </param><param name="createonly">Don't edit the page if it exists already
    ///             </param><param name="nocreate">Throw an error if the page doesn't exist
    ///             </param><param name="watchlist">Unconditionally add or remove the page from your watchlist, use preferences or do not change watch
    ///             </param><param name="md5">The MD5 hash of the text parameter, or the prependtext and appendtext parameters concatenated.
    ///             If set, the edit won't be done unless the hash is correct
    ///             </param><param name="prependtext">Add this text to the beginning of the page. Overrides text
    ///             </param><param name="appendtext">Add this text to the end of the page. Overrides text.
    ///             Use section=new to append a new section
    ///             </param><param name="undo">Undo this revision. Overrides text, prependtext and appendtext
    ///             </param><param name="undoafter">Undo all revisions from undo to this one. If not set, just undo one revision
    ///             </param><param name="redirect">Automatically resolve redirects
    ///             </param><param name="contentformat">Content serialization format used for the input text
    ///             </param><param name="contentmodel">Content model of the new content
    ///             </param><param name="assert">Allows bots to make assertions.
    ///              true   - Always true; nassert=true will fail if the extension is installed.
    ///              false  - Always false; assert=false will fail if the extension is installed.
    ///              user   - Verify that bot is logged in, to prevent anonymous edits.
    ///              bot    - Verify that bot is logged in and has a bot flag.
    ///              exists - Verify that page exists. Could be useful from other extensions, i.e. adding nassert=exists to the inputbox extension.
    ///              test   - Verify that this wiki allows random testing. Defaults to false, but can be overridden in LocalSettings.php.
    ///             </param><param name="nassert">Allows bots to make negative assertions.
    ///              true   - Always true; nassert=true will fail if the extension is installed.
    ///              false  - Always false; assert=false will fail if the extension is installed.
    ///              user   - Verify that bot is logged in, to prevent anonymous edits.
    ///              bot    - Verify that bot is logged in and has a bot flag.
    ///              exists - Verify that page exists. Could be useful from other extensions, i.e. adding nassert=exists to the inputbox extension.
    ///              test   - Verify that this wiki allows random testing. Defaults to false, but can be overridden in LocalSettings.php.
    ///             </param><param name="captchaword">Answer to the CAPTCHA
    ///             </param><param name="captchaid">CAPTCHA ID from previous request
    ///             </param>
    public editResult edit(string token, string title = null, long? pageid = null, string section = null, string sectiontitle = null, string text = null, string summary = null, bool? minor = null, bool? notminor = null, bool? bot = null, string basetimestamp = null, string starttimestamp = null, bool? recreate = null, bool? createonly = null, bool? nocreate = null, editwatchlist watchlist = null, string md5 = null, string prependtext = null, string appendtext = null, int? undo = null, int? undoafter = null, bool? redirect = null, editcontentformat contentformat = null, editcontentmodel contentmodel = null, editassert assert = null, editassert nassert = null, string captchaword = null, string captchaid = null)
    {
      QueryParameters<editResult, editResult> parameters = QueryParameters.Create<editResult>().AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (title != null)
        parameters = parameters.AddSingleValue("title", QueryRepresentation.ToQueryString(title));
      if (pageid.HasValue)
        parameters = parameters.AddSingleValue("pageid", QueryRepresentation.ToQueryString(pageid.Value));
      if (section != null)
        parameters = parameters.AddSingleValue("section", QueryRepresentation.ToQueryString(section));
      if (sectiontitle != null)
        parameters = parameters.AddSingleValue("sectiontitle", QueryRepresentation.ToQueryString(sectiontitle));
      if (text != null)
        parameters = parameters.AddSingleValue("text", QueryRepresentation.ToQueryString(text));
      if (summary != null)
        parameters = parameters.AddSingleValue("summary", QueryRepresentation.ToQueryString(summary));
      if (minor.HasValue)
        parameters = parameters.AddSingleValue("minor", QueryRepresentation.ToQueryString(minor.Value));
      if (notminor.HasValue)
        parameters = parameters.AddSingleValue("notminor", QueryRepresentation.ToQueryString(notminor.Value));
      if (bot.HasValue)
        parameters = parameters.AddSingleValue("bot", QueryRepresentation.ToQueryString(bot.Value));
      if (basetimestamp != null)
        parameters = parameters.AddSingleValue("basetimestamp", QueryRepresentation.ToQueryString(basetimestamp));
      if (starttimestamp != null)
        parameters = parameters.AddSingleValue("starttimestamp", QueryRepresentation.ToQueryString(starttimestamp));
      if (recreate.HasValue)
        parameters = parameters.AddSingleValue("recreate", QueryRepresentation.ToQueryString(recreate.Value));
      if (createonly.HasValue)
        parameters = parameters.AddSingleValue("createonly", QueryRepresentation.ToQueryString(createonly.Value));
      if (nocreate.HasValue)
        parameters = parameters.AddSingleValue("nocreate", QueryRepresentation.ToQueryString(nocreate.Value));
      if (watchlist != (editwatchlist) null)
        parameters = parameters.AddSingleValue("watchlist", QueryRepresentation.ToQueryString((StringValue) watchlist));
      if (md5 != null)
        parameters = parameters.AddSingleValue("md5", QueryRepresentation.ToQueryString(md5));
      if (prependtext != null)
        parameters = parameters.AddSingleValue("prependtext", QueryRepresentation.ToQueryString(prependtext));
      if (appendtext != null)
        parameters = parameters.AddSingleValue("appendtext", QueryRepresentation.ToQueryString(appendtext));
      if (undo.HasValue)
        parameters = parameters.AddSingleValue("undo", QueryRepresentation.ToQueryString(undo.Value));
      if (undoafter.HasValue)
        parameters = parameters.AddSingleValue("undoafter", QueryRepresentation.ToQueryString(undoafter.Value));
      if (redirect.HasValue)
        parameters = parameters.AddSingleValue("redirect", QueryRepresentation.ToQueryString(redirect.Value));
      if (contentformat != (editcontentformat) null)
        parameters = parameters.AddSingleValue("contentformat", QueryRepresentation.ToQueryString((StringValue) contentformat));
      if (contentmodel != (editcontentmodel) null)
        parameters = parameters.AddSingleValue("contentmodel", QueryRepresentation.ToQueryString((StringValue) contentmodel));
      if (assert != (editassert) null)
        parameters = parameters.AddSingleValue("assert", QueryRepresentation.ToQueryString((StringValue) assert));
      if (nassert != (editassert) null)
        parameters = parameters.AddSingleValue("nassert", QueryRepresentation.ToQueryString((StringValue) nassert));
      if (captchaword != null)
        parameters = parameters.AddSingleValue("captchaword", QueryRepresentation.ToQueryString(captchaword));
      if (captchaid != null)
        parameters = parameters.AddSingleValue("captchaid", QueryRepresentation.ToQueryString(captchaid));
      return new QueryProcessor<editResult>(this.m_wiki, Wiki.editProperties).ExecuteSingle<editResult>(parameters);
    }

    /// <summary>
    /// Email a user.
    /// 
    /// </summary>
    /// <param name="target">User to send email to
    ///             </param><param name="text">Mail body
    ///             </param><param name="token">A token previously acquired via prop=info
    ///             </param><param name="subject">Subject header
    ///             </param><param name="ccme">Send a copy of this mail to me
    ///             </param>
    public emailuserResult emailuser(string target, string text, string token, string subject = null, bool? ccme = null)
    {
      QueryParameters<emailuserResult, emailuserResult> parameters = QueryParameters.Create<emailuserResult>().AddSingleValue("target", QueryRepresentation.ToQueryString(target)).AddSingleValue("text", QueryRepresentation.ToQueryString(text)).AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (subject != null)
        parameters = parameters.AddSingleValue("subject", QueryRepresentation.ToQueryString(subject));
      if (ccme.HasValue)
        parameters = parameters.AddSingleValue("ccme", QueryRepresentation.ToQueryString(ccme.Value));
      return new QueryProcessor<emailuserResult>(this.m_wiki, Wiki.emailuserProperties).ExecuteSingle<emailuserResult>(parameters);
    }

    /// <summary>
    /// Expands all templates in wikitext
    /// 
    /// </summary>
    /// <param name="text">Wikitext to convert
    ///             </param><param name="title">Title of page
    ///             </param><param name="generatexml">Generate XML parse tree
    ///             </param><param name="includecomments">Whether to include HTML comments in the output
    ///             </param>
    public expandtemplatesResult expandtemplates(string text, string title = null, bool? generatexml = null, bool? includecomments = null)
    {
      QueryParameters<expandtemplatesResult, expandtemplatesResult> parameters = QueryParameters.Create<expandtemplatesResult>().AddSingleValue("text", QueryRepresentation.ToQueryString(text));
      if (title != null)
        parameters = parameters.AddSingleValue("title", QueryRepresentation.ToQueryString(title));
      if (generatexml.HasValue)
        parameters = parameters.AddSingleValue("generatexml", QueryRepresentation.ToQueryString(generatexml.Value));
      if (includecomments.HasValue)
        parameters = parameters.AddSingleValue("includecomments", QueryRepresentation.ToQueryString(includecomments.Value));
      return new QueryProcessor<expandtemplatesResult>(this.m_wiki, Wiki.expandtemplatesProperties).ExecuteSingle<expandtemplatesResult>(parameters);
    }

    /// <summary>
    /// Revert a file to an old version
    /// 
    /// </summary>
    /// <param name="filename">Target filename without the File: prefix
    ///             </param><param name="archivename">Archive name of the revision to revert to
    ///             </param><param name="token">Edit token. You can get one of these through prop=info
    ///             </param><param name="comment">Upload comment
    ///             </param>
    public filerevertResult filerevert(string filename, string archivename, string token, string comment = null)
    {
      QueryParameters<filerevertResult, filerevertResult> parameters = QueryParameters.Create<filerevertResult>().AddSingleValue("filename", QueryRepresentation.ToQueryString(filename)).AddSingleValue("archivename", QueryRepresentation.ToQueryString(archivename)).AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (comment != null)
        parameters = parameters.AddSingleValue("comment", QueryRepresentation.ToQueryString(comment));
      return new QueryProcessor<filerevertResult>(this.m_wiki, Wiki.filerevertProperties).ExecuteSingle<filerevertResult>(parameters);
    }

    /// <summary>
    /// Import a page from another wiki, or an XML file.
    ///             Note that the HTTP POST must be done as a file upload (i.e. using multipart/form-data) when
    ///             sending a file for the "xml" parameter.
    /// 
    /// </summary>
    /// <param name="token">Import token obtained through prop=info
    ///             </param><param name="summary">Import summary
    ///             </param><param name="xml">Uploaded XML file
    ///             </param><param name="interwikisource">For interwiki imports: wiki to import from
    ///             </param><param name="interwikipage">For interwiki imports: page to import
    ///             </param><param name="fullhistory">For interwiki imports: import the full history, not just the current version
    ///             </param><param name="templates">For interwiki imports: import all included templates as well
    ///             </param><param name="ns">For interwiki imports: import to this namespace
    ///             </param><param name="rootpage">Import as subpage of this page
    ///             </param>
    public IEnumerable<importResult> import(string token, string summary = null, Stream xml = null, importinterwikisource interwikisource = null, string interwikipage = null, bool? fullhistory = null, bool? templates = null, Namespace ns = null, string rootpage = null)
    {
      QueryParameters<importResult, importResult> parameters = QueryParameters.Create<importResult>().AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (summary != null)
        parameters = parameters.AddSingleValue("summary", QueryRepresentation.ToQueryString(summary));
      if (xml != null)
        parameters = parameters.AddFile("xml", xml);
      if (interwikisource != (importinterwikisource) null)
        parameters = parameters.AddSingleValue("interwikisource", QueryRepresentation.ToQueryString((StringValue) interwikisource));
      if (interwikipage != null)
        parameters = parameters.AddSingleValue("interwikipage", QueryRepresentation.ToQueryString(interwikipage));
      if (fullhistory.HasValue)
        parameters = parameters.AddSingleValue("fullhistory", QueryRepresentation.ToQueryString(fullhistory.Value));
      if (templates.HasValue)
        parameters = parameters.AddSingleValue("templates", QueryRepresentation.ToQueryString(templates.Value));
      if (ns != (Namespace) null)
        parameters = parameters.AddSingleValue("namespace", QueryRepresentation.ToQueryString(ns));
      if (rootpage != null)
        parameters = parameters.AddSingleValue("rootpage", QueryRepresentation.ToQueryString(rootpage));
      return new QueryProcessor<importResult>(this.m_wiki, Wiki.importProperties).ExecuteList<importResult>(parameters);
    }

    /// <summary>
    /// Log in and get the authentication tokens.
    ///             In the event of a successful log-in, a cookie will be attached
    ///             to your session. In the event of a failed log-in, you will not
    ///             be able to attempt another log-in through this method for 5 seconds.
    ///             This is to prevent password guessing by automated password crackers
    /// 
    /// </summary>
    /// <param name="name">User Name
    ///             </param><param name="password">Password
    ///             </param><param name="domain">Domain (optional)
    ///             </param><param name="token">Login token obtained in first request
    ///             </param>
    public loginResult login(string name = null, string password = null, string domain = null, string token = null)
    {
      QueryParameters<loginResult, loginResult> parameters = QueryParameters.Create<loginResult>();
      if (name != null)
        parameters = parameters.AddSingleValue("name", QueryRepresentation.ToQueryString(name));
      if (password != null)
        parameters = parameters.AddSingleValue("password", QueryRepresentation.ToQueryString(password));
      if (domain != null)
        parameters = parameters.AddSingleValue("domain", QueryRepresentation.ToQueryString(domain));
      if (token != null)
        parameters = parameters.AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      return new QueryProcessor<loginResult>(this.m_wiki, Wiki.loginProperties).ExecuteSingle<loginResult>(parameters);
    }

    /// <summary>
    /// Log out and clear session data
    /// 
    /// </summary>
    public void logout()
    {
      QueryParameters<object, object> parameters = QueryParameters.Create<object>();
      new QueryProcessor<object>(this.m_wiki, Wiki.logoutProperties).ExecuteSingle<object>(parameters);
    }

    /// <summary>
    /// Move a page
    /// 
    /// </summary>
    /// <param name="to">Title you want to rename the page to
    ///             </param><param name="token">A move token previously retrieved through prop=info
    ///             </param><param name="from">Title of the page you want to move. Cannot be used together with fromid
    ///             </param><param name="fromid">Page ID of the page you want to move. Cannot be used together with from
    ///             </param><param name="reason">Reason for the move
    ///             </param><param name="movetalk">Move the talk page, if it exists
    ///             </param><param name="movesubpages">Move subpages, if applicable
    ///             </param><param name="noredirect">Don't create a redirect
    ///             </param><param name="watchlist">Unconditionally add or remove the page from your watchlist, use preferences or do not change watch
    ///             </param><param name="ignorewarnings">Ignore any warnings
    ///             </param>
    public moveResult move(string to, string token, string from = null, long? fromid = null, string reason = null, bool? movetalk = null, bool? movesubpages = null, bool? noredirect = null, movewatchlist watchlist = null, bool? ignorewarnings = null)
    {
      QueryParameters<moveResult, moveResult> parameters = QueryParameters.Create<moveResult>().AddSingleValue("to", QueryRepresentation.ToQueryString(to)).AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (from != null)
        parameters = parameters.AddSingleValue("from", QueryRepresentation.ToQueryString(from));
      if (fromid.HasValue)
        parameters = parameters.AddSingleValue("fromid", QueryRepresentation.ToQueryString(fromid.Value));
      if (reason != null)
        parameters = parameters.AddSingleValue("reason", QueryRepresentation.ToQueryString(reason));
      if (movetalk.HasValue)
        parameters = parameters.AddSingleValue("movetalk", QueryRepresentation.ToQueryString(movetalk.Value));
      if (movesubpages.HasValue)
        parameters = parameters.AddSingleValue("movesubpages", QueryRepresentation.ToQueryString(movesubpages.Value));
      if (noredirect.HasValue)
        parameters = parameters.AddSingleValue("noredirect", QueryRepresentation.ToQueryString(noredirect.Value));
      if (watchlist != (movewatchlist) null)
        parameters = parameters.AddSingleValue("watchlist", QueryRepresentation.ToQueryString((StringValue) watchlist));
      if (ignorewarnings.HasValue)
        parameters = parameters.AddSingleValue("ignorewarnings", QueryRepresentation.ToQueryString(ignorewarnings.Value));
      return new QueryProcessor<moveResult>(this.m_wiki, Wiki.moveProperties).ExecuteSingle<moveResult>(parameters);
    }

    /// <summary>
    /// Change preferences of the current user
    ///             Only options which are registered in core or in one of installed extensions,
    ///             or as options with keys prefixed with 'userjs-' (intended to be used by user scripts), can be set.
    /// 
    /// </summary>
    /// <param name="token">An options token previously obtained through the action=tokens
    ///             </param><param name="reset">Resets preferences to the site defaults
    ///             </param><param name="resetkinds">List of types of options to reset when the "reset" option is set
    ///             </param><param name="change">List of changes, formatted name=value (e.g. skin=vector), value cannot contain pipe characters. If no value is given (not even an equals sign), e.g., optionname|otheroption|..., the option will be reset to its default value
    ///             </param><param name="optionname">A name of a option which should have an optionvalue set
    ///             </param><param name="optionvalue">A value of the option specified by the optionname, can contain pipe characters
    ///             </param>
    public optionsResult options(string token, bool? reset = null, IEnumerable<optionsresetkinds> resetkinds = null, IEnumerable<string> change = null, string optionname = null, string optionvalue = null)
    {
      QueryParameters<optionsResult, optionsResult> parameters = QueryParameters.Create<optionsResult>().AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (reset.HasValue)
        parameters = parameters.AddSingleValue("reset", QueryRepresentation.ToQueryString(reset.Value));
      if (resetkinds != null)
        parameters = parameters.AddSingleValue("resetkinds", QueryRepresentation.ToQueryString<optionsresetkinds>(resetkinds));
      if (change != null)
        parameters = parameters.AddSingleValue("change", QueryRepresentation.ToQueryString<string>(change));
      if (optionname != null)
        parameters = parameters.AddSingleValue("optionname", QueryRepresentation.ToQueryString(optionname));
      if (optionvalue != null)
        parameters = parameters.AddSingleValue("optionvalue", QueryRepresentation.ToQueryString(optionvalue));
      return new QueryProcessor<optionsResult>(this.m_wiki, Wiki.optionsProperties).ExecuteSingle<optionsResult>(parameters);
    }

    /// <summary>
    /// Patrol a page or revision
    /// 
    /// </summary>
    /// <param name="token">Patrol token obtained from list=recentchanges
    ///             </param><param name="rcid">Recentchanges ID to patrol
    ///             </param><param name="revid">Revision ID to patrol
    ///             </param>
    public patrolResult patrol(string token, long? rcid = null, long? revid = null)
    {
      QueryParameters<patrolResult, patrolResult> parameters = QueryParameters.Create<patrolResult>().AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (rcid.HasValue)
        parameters = parameters.AddSingleValue("rcid", QueryRepresentation.ToQueryString(rcid.Value));
      if (revid.HasValue)
        parameters = parameters.AddSingleValue("revid", QueryRepresentation.ToQueryString(revid.Value));
      return new QueryProcessor<patrolResult>(this.m_wiki, Wiki.patrolProperties).ExecuteSingle<patrolResult>(parameters);
    }

    /// <summary>
    /// Change the protection level of a page
    /// 
    /// </summary>
    /// <param name="token">A protect token previously retrieved through prop=info
    ///             </param><param name="protections">List of protection levels, formatted action=group (e.g. edit=sysop)
    ///             </param><param name="title">Title of the page you want to (un)protect. Cannot be used together with pageid
    ///             </param><param name="pageid">ID of the page you want to (un)protect. Cannot be used together with title
    ///             </param><param name="expiry">Expiry timestamps. If only one timestamp is set, it'll be used for all protections.
    ///             Use 'infinite', 'indefinite' or 'never', for a never-expiring protection.
    ///             </param><param name="reason">Reason for (un)protecting
    ///             </param><param name="cascade">Enable cascading protection (i.e. protect pages included in this page)
    ///             Ignored if not all protection levels are 'sysop' or 'protect'
    ///             </param><param name="watchlist">Unconditionally add or remove the page from your watchlist, use preferences or do not change watch
    ///             </param>
    public protectResult protect(string token, IEnumerable<string> protections, string title = null, long? pageid = null, IEnumerable<string> expiry = null, string reason = null, bool? cascade = null, protectwatchlist watchlist = null)
    {
      QueryParameters<protectResult, protectResult> parameters = QueryParameters.Create<protectResult>().AddSingleValue("token", QueryRepresentation.ToQueryString(token)).AddSingleValue("protections", QueryRepresentation.ToQueryString<string>(protections));
      if (title != null)
        parameters = parameters.AddSingleValue("title", QueryRepresentation.ToQueryString(title));
      if (pageid.HasValue)
        parameters = parameters.AddSingleValue("pageid", QueryRepresentation.ToQueryString(pageid.Value));
      if (expiry != null)
        parameters = parameters.AddSingleValue("expiry", QueryRepresentation.ToQueryString<string>(expiry));
      if (reason != null)
        parameters = parameters.AddSingleValue("reason", QueryRepresentation.ToQueryString(reason));
      if (cascade.HasValue)
        parameters = parameters.AddSingleValue("cascade", QueryRepresentation.ToQueryString(cascade.Value));
      if (watchlist != (protectwatchlist) null)
        parameters = parameters.AddSingleValue("watchlist", QueryRepresentation.ToQueryString((StringValue) watchlist));
      return new QueryProcessor<protectResult>(this.m_wiki, Wiki.protectProperties).ExecuteSingle<protectResult>(parameters);
    }

    /// <summary>
    /// Purge the cache for the given titles.
    ///             Requires a POST request if the user is not logged in.
    /// 
    /// </summary>
    /// <param name="forcelinkupdate">Update the links tables
    ///             </param><param name="forcerecursivelinkupdate">Update the links table, and update the links tables for any page that uses this page as a template
    ///             </param><param name="titles">A list of titles to work on
    ///             </param><param name="pageids">A list of page IDs to work on
    ///             </param><param name="revids">A list of revision IDs to work on
    ///             </param><param name="redirects">Automatically resolve redirects
    ///             </param><param name="converttitles">Convert titles to other variants if necessary. Only works if the wiki's content language supports variant conversion.
    ///             Languages that support variant conversion include gan, iu, kk, ku, shi, sr, tg, uz, zh
    ///             </param><param name="generator">Get the list of pages to work on by executing the specified query module.
    ///             NOTE: generator parameter names must be prefixed with a 'g', see examples
    ///             </param>
    public IEnumerable<purgeResult> purge(bool? forcelinkupdate = null, bool? forcerecursivelinkupdate = null, IEnumerable<string> titles = null, IEnumerable<int> pageids = null, IEnumerable<int> revids = null, bool? redirects = null, bool? converttitles = null, purgegenerator generator = null)
    {
      QueryParameters<purgeResult, purgeResult> parameters = QueryParameters.Create<purgeResult>();
      if (forcelinkupdate.HasValue)
        parameters = parameters.AddSingleValue("forcelinkupdate", QueryRepresentation.ToQueryString(forcelinkupdate.Value));
      if (forcerecursivelinkupdate.HasValue)
        parameters = parameters.AddSingleValue("forcerecursivelinkupdate", QueryRepresentation.ToQueryString(forcerecursivelinkupdate.Value));
      if (titles != null)
        parameters = parameters.AddSingleValue("titles", QueryRepresentation.ToQueryString<string>(titles));
      if (pageids != null)
        parameters = parameters.AddSingleValue("pageids", QueryRepresentation.ToQueryString<int>(pageids));
      if (revids != null)
        parameters = parameters.AddSingleValue("revids", QueryRepresentation.ToQueryString<int>(revids));
      if (redirects.HasValue)
        parameters = parameters.AddSingleValue("redirects", QueryRepresentation.ToQueryString(redirects.Value));
      if (converttitles.HasValue)
        parameters = parameters.AddSingleValue("converttitles", QueryRepresentation.ToQueryString(converttitles.Value));
      if (generator != (purgegenerator) null)
        parameters = parameters.AddSingleValue("generator", QueryRepresentation.ToQueryString((StringValue) generator));
      return new QueryProcessor<purgeResult>(this.m_wiki, Wiki.purgeProperties).ExecuteList<purgeResult>(parameters);
    }

    /// <summary>
    /// Undo the last edit to the page. If the last user who edited the page made multiple edits in a row,
    ///             they will all be rolled back
    /// 
    /// </summary>
    /// <param name="title">Title of the page you want to rollback.
    ///             </param><param name="user">Name of the user whose edits are to be rolled back. If set incorrectly, you'll get a badtoken error.
    ///             </param><param name="token">A rollback token previously retrieved through prop=revisions
    ///             </param><param name="summary">Custom edit summary. If empty, default summary will be used
    ///             </param><param name="markbot">Mark the reverted edits and the revert as bot edits
    ///             </param><param name="watchlist">Unconditionally add or remove the page from your watchlist, use preferences or do not change watch
    ///             </param>
    public rollbackResult rollback(string title, string user, string token, string summary = null, bool? markbot = null, rollbackwatchlist watchlist = null)
    {
      QueryParameters<rollbackResult, rollbackResult> parameters = QueryParameters.Create<rollbackResult>().AddSingleValue("title", QueryRepresentation.ToQueryString(title)).AddSingleValue("user", QueryRepresentation.ToQueryString(user)).AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (summary != null)
        parameters = parameters.AddSingleValue("summary", QueryRepresentation.ToQueryString(summary));
      if (markbot.HasValue)
        parameters = parameters.AddSingleValue("markbot", QueryRepresentation.ToQueryString(markbot.Value));
      if (watchlist != (rollbackwatchlist) null)
        parameters = parameters.AddSingleValue("watchlist", QueryRepresentation.ToQueryString((StringValue) watchlist));
      return new QueryProcessor<rollbackResult>(this.m_wiki, Wiki.rollbackProperties).ExecuteSingle<rollbackResult>(parameters);
    }

    /// <summary>
    /// Set a global user's status.
    /// 
    /// </summary>
    /// <param name="user">User to change the status of.
    ///             </param><param name="token">Your token (obtained from action=tokens&amp;type=setglobalaccountstatus).
    ///             </param><param name="locked">Change whether this user is locked or not.
    ///             </param><param name="hidden">Change whether this user is not hidden, hidden from lists, or suppressed.
    ///             </param><param name="reason">Reason for changing the user's status.
    ///             </param><param name="statecheck">Optional MD5 of the expected current &lt;username&gt;:&lt;hidden&gt;:&lt;locked&gt;, to detect edit conflicts. Set &lt;locked&gt; to 1 for locked, 0 for unlocked.
    ///             </param>
    public setglobalaccountstatusResult setglobalaccountstatus(string user, string token, setglobalaccountstatuslocked locked = null, setglobalaccountstatushidden hidden = null, string reason = null, string statecheck = null)
    {
      QueryParameters<setglobalaccountstatusResult, setglobalaccountstatusResult> parameters = QueryParameters.Create<setglobalaccountstatusResult>().AddSingleValue("user", QueryRepresentation.ToQueryString(user)).AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (locked != (setglobalaccountstatuslocked) null)
        parameters = parameters.AddSingleValue("locked", QueryRepresentation.ToQueryString((StringValue) locked));
      if (hidden != (setglobalaccountstatushidden) null)
        parameters = parameters.AddSingleValue("hidden", QueryRepresentation.ToQueryString((StringValue) hidden));
      if (reason != null)
        parameters = parameters.AddSingleValue("reason", QueryRepresentation.ToQueryString(reason));
      if (statecheck != null)
        parameters = parameters.AddSingleValue("statecheck", QueryRepresentation.ToQueryString(statecheck));
      return new QueryProcessor<setglobalaccountstatusResult>(this.m_wiki, Wiki.setglobalaccountstatusProperties).ExecuteSingle<setglobalaccountstatusResult>(parameters);
    }

    /// <summary>
    /// Update the notification timestamp for watched pages.
    ///             This affects the highlighting of changed pages in the watchlist and history,
    ///             and the sending of email when the "Email me when a page on my watchlist is
    ///             changed" preference is enabled.
    /// 
    /// </summary>
    /// <param name="entirewatchlist">Work on all watched pages
    ///             </param><param name="token">A token previously acquired via prop=info
    ///             </param><param name="timestamp">Timestamp to which to set the notification timestamp
    ///             </param><param name="torevid">Revision to set the notification timestamp to (one page only)
    ///             </param><param name="newerthanrevid">Revision to set the notification timestamp newer than (one page only)
    ///             </param><param name="titles">A list of titles to work on
    ///             </param><param name="pageids">A list of page IDs to work on
    ///             </param><param name="revids">A list of revision IDs to work on
    ///             </param><param name="redirects">Automatically resolve redirects
    ///             </param><param name="converttitles">Convert titles to other variants if necessary. Only works if the wiki's content language supports variant conversion.
    ///             Languages that support variant conversion include gan, iu, kk, ku, shi, sr, tg, uz, zh
    ///             </param><param name="generator">Get the list of pages to work on by executing the specified query module.
    ///             NOTE: generator parameter names must be prefixed with a 'g', see examples
    ///             </param>
    public IEnumerable<setnotificationtimestampResult> setnotificationtimestamp(bool? entirewatchlist = null, string token = null, DateTime? timestamp = null, long? torevid = null, long? newerthanrevid = null, IEnumerable<string> titles = null, IEnumerable<int> pageids = null, IEnumerable<int> revids = null, bool? redirects = null, bool? converttitles = null, setnotificationtimestampgenerator generator = null)
    {
      QueryParameters<setnotificationtimestampResult, setnotificationtimestampResult> parameters = QueryParameters.Create<setnotificationtimestampResult>();
      if (entirewatchlist.HasValue)
        parameters = parameters.AddSingleValue("entirewatchlist", QueryRepresentation.ToQueryString(entirewatchlist.Value));
      if (token != null)
        parameters = parameters.AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (timestamp.HasValue)
        parameters = parameters.AddSingleValue("timestamp", QueryRepresentation.ToQueryString(timestamp.Value));
      if (torevid.HasValue)
        parameters = parameters.AddSingleValue("torevid", QueryRepresentation.ToQueryString(torevid.Value));
      if (newerthanrevid.HasValue)
        parameters = parameters.AddSingleValue("newerthanrevid", QueryRepresentation.ToQueryString(newerthanrevid.Value));
      if (titles != null)
        parameters = parameters.AddSingleValue("titles", QueryRepresentation.ToQueryString<string>(titles));
      if (pageids != null)
        parameters = parameters.AddSingleValue("pageids", QueryRepresentation.ToQueryString<int>(pageids));
      if (revids != null)
        parameters = parameters.AddSingleValue("revids", QueryRepresentation.ToQueryString<int>(revids));
      if (redirects.HasValue)
        parameters = parameters.AddSingleValue("redirects", QueryRepresentation.ToQueryString(redirects.Value));
      if (converttitles.HasValue)
        parameters = parameters.AddSingleValue("converttitles", QueryRepresentation.ToQueryString(converttitles.Value));
      if (generator != (setnotificationtimestampgenerator) null)
        parameters = parameters.AddSingleValue("generator", QueryRepresentation.ToQueryString((StringValue) generator));
      return new QueryProcessor<setnotificationtimestampResult>(this.m_wiki, Wiki.setnotificationtimestampProperties).ExecuteList<setnotificationtimestampResult>(parameters);
    }

    /// <summary>
    /// Gets tokens for data-modifying actions
    /// 
    /// </summary>
    /// <param name="type">Type of token(s) to request
    ///             </param>
    public tokensResult tokens(IEnumerable<tokenstype> type = null)
    {
      QueryParameters<tokensResult, tokensResult> parameters = QueryParameters.Create<tokensResult>();
      if (type != null)
        parameters = parameters.AddSingleValue("type", QueryRepresentation.ToQueryString<tokenstype>(type));
      return new QueryProcessor<tokensResult>(this.m_wiki, Wiki.tokensProperties).ExecuteSingle<tokensResult>(parameters);
    }

    /// <summary>
    /// Unblock a user
    /// 
    /// </summary>
    /// <param name="id">ID of the block you want to unblock (obtained through list=blocks). Cannot be used together with user
    ///             </param><param name="user">Username, IP address or IP range you want to unblock. Cannot be used together with id
    ///             </param><param name="token">An unblock token previously obtained through prop=info
    ///             </param><param name="reason">Reason for unblock
    ///             </param>
    public unblockResult unblock(long? id = null, string user = null, string token = null, string reason = null)
    {
      QueryParameters<unblockResult, unblockResult> parameters = QueryParameters.Create<unblockResult>();
      if (id.HasValue)
        parameters = parameters.AddSingleValue("id", QueryRepresentation.ToQueryString(id.Value));
      if (user != null)
        parameters = parameters.AddSingleValue("user", QueryRepresentation.ToQueryString(user));
      if (token != null)
        parameters = parameters.AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (reason != null)
        parameters = parameters.AddSingleValue("reason", QueryRepresentation.ToQueryString(reason));
      return new QueryProcessor<unblockResult>(this.m_wiki, Wiki.unblockProperties).ExecuteSingle<unblockResult>(parameters);
    }

    /// <summary>
    /// Restore certain revisions of a deleted page. A list of deleted revisions (including timestamps) can be
    ///             retrieved through list=deletedrevs
    /// 
    /// </summary>
    /// <param name="title">Title of the page you want to restore
    ///             </param><param name="token">An undelete token previously retrieved through list=deletedrevs
    ///             </param><param name="reason">Reason for restoring
    ///             </param><param name="timestamps">Timestamps of the revisions to restore. If not set, all revisions will be restored.
    ///             </param><param name="watchlist">Unconditionally add or remove the page from your watchlist, use preferences or do not change watch
    ///             </param>
    public undeleteResult undelete(string title, string token, string reason = null, IEnumerable<DateTime> timestamps = null, undeletewatchlist watchlist = null)
    {
      QueryParameters<undeleteResult, undeleteResult> parameters = QueryParameters.Create<undeleteResult>().AddSingleValue("title", QueryRepresentation.ToQueryString(title)).AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (reason != null)
        parameters = parameters.AddSingleValue("reason", QueryRepresentation.ToQueryString(reason));
      if (timestamps != null)
        parameters = parameters.AddSingleValue("timestamps", QueryRepresentation.ToQueryString<DateTime>(timestamps));
      if (watchlist != (undeletewatchlist) null)
        parameters = parameters.AddSingleValue("watchlist", QueryRepresentation.ToQueryString((StringValue) watchlist));
      return new QueryProcessor<undeleteResult>(this.m_wiki, Wiki.undeleteProperties).ExecuteSingle<undeleteResult>(parameters);
    }

    /// <summary>
    /// Upload a file, or get the status of pending uploads. Several methods are available:
    ///              * Upload file contents directly, using the "file" parameter
    ///              * Have the MediaWiki server fetch a file from a URL, using the "url" parameter
    ///              * Complete an earlier upload that failed due to warnings, using the "filekey" parameter
    ///             Note that the HTTP POST must be done as a file upload (i.e. using multipart/form-data) when
    ///             sending the "file". Also you must get and send an edit token before doing any upload stuff
    /// 
    /// </summary>
    /// <param name="token">Edit token. You can get one of these through prop=info
    ///             </param><param name="filename">Target filename
    ///             </param><param name="comment">Upload comment. Also used as the initial page text for new files if "text" is not specified
    ///             </param><param name="text">Initial page text for new files
    ///             </param><param name="watchlist">Unconditionally add or remove the page from your watchlist, use preferences or do not change watch
    ///             </param><param name="ignorewarnings">Ignore any warnings
    ///             </param><param name="file">File contents
    ///             </param><param name="url">URL to fetch the file from
    ///             </param><param name="filekey">Key that identifies a previous upload that was stashed temporarily.
    ///             </param><param name="stash">If set, the server will not add the file to the repository and stash it temporarily.
    ///             </param><param name="filesize">Filesize of entire upload
    ///             </param><param name="offset">Offset of chunk in bytes
    ///             </param><param name="chunk">Chunk contents
    ///             </param><param name="async">Make potentially large file operations asynchronous when possible
    ///             </param><param name="asyncdownload">Make fetching a URL asynchronous
    ///             </param><param name="leavemessage">If asyncdownload is used, leave a message on the user talk page if finished
    ///             </param><param name="statuskey">Fetch the upload status for this file key (upload by URL)
    ///             </param><param name="checkstatus">Only fetch the upload status for the given file key
    ///             </param>
    public uploadResult upload(string token, string filename = null, string comment = null, string text = null, uploadwatchlist watchlist = null, bool? ignorewarnings = null, Stream file = null, string url = null, string filekey = null, bool? stash = null, string filesize = null, string offset = null, Stream chunk = null, bool? async = null, bool? asyncdownload = null, bool? leavemessage = null, string statuskey = null, bool? checkstatus = null)
    {
      QueryParameters<uploadResult, uploadResult> parameters = QueryParameters.Create<uploadResult>().AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (filename != null)
        parameters = parameters.AddSingleValue("filename", QueryRepresentation.ToQueryString(filename));
      if (comment != null)
        parameters = parameters.AddSingleValue("comment", QueryRepresentation.ToQueryString(comment));
      if (text != null)
        parameters = parameters.AddSingleValue("text", QueryRepresentation.ToQueryString(text));
      if (watchlist != (uploadwatchlist) null)
        parameters = parameters.AddSingleValue("watchlist", QueryRepresentation.ToQueryString((StringValue) watchlist));
      if (ignorewarnings.HasValue)
        parameters = parameters.AddSingleValue("ignorewarnings", QueryRepresentation.ToQueryString(ignorewarnings.Value));
      if (file != null)
        parameters = parameters.AddFile("file", file);
      if (url != null)
        parameters = parameters.AddSingleValue("url", QueryRepresentation.ToQueryString(url));
      if (filekey != null)
        parameters = parameters.AddSingleValue("filekey", QueryRepresentation.ToQueryString(filekey));
      if (stash.HasValue)
        parameters = parameters.AddSingleValue("stash", QueryRepresentation.ToQueryString(stash.Value));
      if (filesize != null)
        parameters = parameters.AddSingleValue("filesize", QueryRepresentation.ToQueryString(filesize));
      if (offset != null)
        parameters = parameters.AddSingleValue("offset", QueryRepresentation.ToQueryString(offset));
      if (chunk != null)
        parameters = parameters.AddFile("chunk", chunk);
      if (async.HasValue)
        parameters = parameters.AddSingleValue("async", QueryRepresentation.ToQueryString(async.Value));
      if (asyncdownload.HasValue)
        parameters = parameters.AddSingleValue("asyncdownload", QueryRepresentation.ToQueryString(asyncdownload.Value));
      if (leavemessage.HasValue)
        parameters = parameters.AddSingleValue("leavemessage", QueryRepresentation.ToQueryString(leavemessage.Value));
      if (statuskey != null)
        parameters = parameters.AddSingleValue("statuskey", QueryRepresentation.ToQueryString(statuskey));
      if (checkstatus.HasValue)
        parameters = parameters.AddSingleValue("checkstatus", QueryRepresentation.ToQueryString(checkstatus.Value));
      return new QueryProcessor<uploadResult>(this.m_wiki, Wiki.uploadProperties).ExecuteSingle<uploadResult>(parameters);
    }

    /// <summary>
    /// Add or remove a page from/to the current user's watchlist
    /// 
    /// </summary>
    /// <param name="title">The page to (un)watch
    ///             </param><param name="token">A token previously acquired via prop=info
    ///             </param><param name="unwatch">If set the page will be unwatched rather than watched
    ///             </param><param name="uselang">Language to show the message in
    ///             </param>
    public watchResult watch(string title, string token, bool? unwatch = null, string uselang = null)
    {
      QueryParameters<watchResult, watchResult> parameters = QueryParameters.Create<watchResult>().AddSingleValue("title", QueryRepresentation.ToQueryString(title)).AddSingleValue("token", QueryRepresentation.ToQueryString(token));
      if (unwatch.HasValue)
        parameters = parameters.AddSingleValue("unwatch", QueryRepresentation.ToQueryString(unwatch.Value));
      if (uselang != null)
        parameters = parameters.AddSingleValue("uselang", QueryRepresentation.ToQueryString(uselang));
      return new QueryProcessor<watchResult>(this.m_wiki, Wiki.watchProperties).ExecuteSingle<watchResult>(parameters);
    }
  }
}
