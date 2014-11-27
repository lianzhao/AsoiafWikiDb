// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.QueryAction
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
using System.Xml.Linq;

namespace LinqToWiki.Generated
{
  public sealed class QueryAction
  {
    private static readonly IDictionary<string, string[]> allcategoriesProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "*",
        new string[1]
        {
          ""
        }
      },
      {
        "size",
        new string[1]
        {
          "size"
        }
      },
      {
        "pages",
        new string[1]
        {
          "size"
        }
      },
      {
        "files",
        new string[1]
        {
          "size"
        }
      },
      {
        "subcats",
        new string[1]
        {
          "size"
        }
      },
      {
        "hidden",
        new string[1]
        {
          "hidden"
        }
      }
    };
    private static readonly QueryTypeProperties<allcategoriesSelect> allcategoriesProperties = new QueryTypeProperties<allcategoriesSelect>("allcategories", "ac", new QueryType?(QueryType.List), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "allcategories"
      }
    }, QueryAction.allcategoriesProps, new Func<XElement, WikiInfo, allcategoriesSelect>(allcategoriesSelect.Parse));
    private static readonly IDictionary<string, string[]> allimagesProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "name",
        new string[1]
        {
          ""
        }
      },
      {
        "ns",
        new string[1]
        {
          ""
        }
      },
      {
        "title",
        new string[1]
        {
          ""
        }
      },
      {
        "timestamp",
        new string[1]
        {
          "timestamp"
        }
      },
      {
        "userhidden",
        new string[2]
        {
          "user",
          "userid"
        }
      },
      {
        "user",
        new string[1]
        {
          "user"
        }
      },
      {
        "anon",
        new string[2]
        {
          "user",
          "userid"
        }
      },
      {
        "userid",
        new string[1]
        {
          "userid"
        }
      },
      {
        "size",
        new string[2]
        {
          "size",
          "dimensions"
        }
      },
      {
        "width",
        new string[2]
        {
          "size",
          "dimensions"
        }
      },
      {
        "height",
        new string[2]
        {
          "size",
          "dimensions"
        }
      },
      {
        "pagecount",
        new string[2]
        {
          "size",
          "dimensions"
        }
      },
      {
        "commenthidden",
        new string[2]
        {
          "comment",
          "parsedcomment"
        }
      },
      {
        "comment",
        new string[1]
        {
          "comment"
        }
      },
      {
        "parsedcomment",
        new string[1]
        {
          "parsedcomment"
        }
      },
      {
        "filehidden",
        new string[5]
        {
          "url",
          "sha1",
          "mime",
          "mediatype",
          "bitdepth"
        }
      },
      {
        "thumburl",
        new string[1]
        {
          "url"
        }
      },
      {
        "thumbwidth",
        new string[1]
        {
          "url"
        }
      },
      {
        "thumbheight",
        new string[1]
        {
          "url"
        }
      },
      {
        "thumberror",
        new string[1]
        {
          "url"
        }
      },
      {
        "url",
        new string[1]
        {
          "url"
        }
      },
      {
        "descriptionurl",
        new string[1]
        {
          "url"
        }
      },
      {
        "sha1",
        new string[1]
        {
          "sha1"
        }
      },
      {
        "mime",
        new string[1]
        {
          "mime"
        }
      },
      {
        "mediatype",
        new string[1]
        {
          "mediatype"
        }
      },
      {
        "bitdepth",
        new string[1]
        {
          "bitdepth"
        }
      }
    };
    private static readonly QueryTypeProperties<allimagesSelect> allimagesProperties = new QueryTypeProperties<allimagesSelect>("allimages", "ai", new QueryType?(QueryType.List), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "allimages"
      }
    }, QueryAction.allimagesProps, new Func<XElement, WikiInfo, allimagesSelect>(allimagesSelect.Parse));
    private static readonly IDictionary<string, string[]> alllinksProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "fromid",
        new string[1]
        {
          "ids"
        }
      },
      {
        "ns",
        new string[1]
        {
          "title"
        }
      },
      {
        "title",
        new string[1]
        {
          "title"
        }
      }
    };
    private static readonly QueryTypeProperties<alllinksSelect> alllinksProperties = new QueryTypeProperties<alllinksSelect>("alllinks", "al", new QueryType?(QueryType.List), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "alllinks"
      }
    }, QueryAction.alllinksProps, new Func<XElement, WikiInfo, alllinksSelect>(alllinksSelect.Parse));
    private static readonly IDictionary<string, string[]> allmessagesProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "name",
        new string[1]
        {
          ""
        }
      },
      {
        "customised",
        new string[1]
        {
          ""
        }
      },
      {
        "missing",
        new string[1]
        {
          ""
        }
      },
      {
        "*",
        new string[1]
        {
          ""
        }
      },
      {
        "defaultmissing",
        new string[1]
        {
          "default"
        }
      },
      {
        "default",
        new string[1]
        {
          "default"
        }
      }
    };
    private static readonly QueryTypeProperties<allmessagesSelect> allmessagesProperties = new QueryTypeProperties<allmessagesSelect>("allmessages", "am", new QueryType?(QueryType.Meta), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "meta",
        "allmessages"
      }
    }, QueryAction.allmessagesProps, new Func<XElement, WikiInfo, allmessagesSelect>(allmessagesSelect.Parse));
    private static readonly IDictionary<string, string[]> allpagesProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "pageid",
        new string[1]
        {
          ""
        }
      },
      {
        "ns",
        new string[1]
        {
          ""
        }
      },
      {
        "title",
        new string[1]
        {
          ""
        }
      }
    };
    private static readonly QueryTypeProperties<allpagesSelect> allpagesProperties = new QueryTypeProperties<allpagesSelect>("allpages", "ap", new QueryType?(QueryType.List), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "allpages"
      }
    }, QueryAction.allpagesProps, new Func<XElement, WikiInfo, allpagesSelect>(allpagesSelect.Parse));
    private static readonly IDictionary<string, string[]> alltransclusionsProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "fromid",
        new string[1]
        {
          "ids"
        }
      },
      {
        "ns",
        new string[1]
        {
          "title"
        }
      },
      {
        "title",
        new string[1]
        {
          "title"
        }
      }
    };
    private static readonly QueryTypeProperties<alltransclusionsSelect> alltransclusionsProperties = new QueryTypeProperties<alltransclusionsSelect>("alltransclusions", "at", new QueryType?(QueryType.List), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "alltransclusions"
      }
    }, QueryAction.alltransclusionsProps, new Func<XElement, WikiInfo, alltransclusionsSelect>(alltransclusionsSelect.Parse));
    private static readonly IDictionary<string, string[]> allusersProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "userid",
        new string[1]
        {
          ""
        }
      },
      {
        "name",
        new string[1]
        {
          ""
        }
      },
      {
        "recenteditcount",
        new string[1]
        {
          ""
        }
      },
      {
        "blockid",
        new string[1]
        {
          "blockinfo"
        }
      },
      {
        "blockedby",
        new string[1]
        {
          "blockinfo"
        }
      },
      {
        "blockedbyid",
        new string[1]
        {
          "blockinfo"
        }
      },
      {
        "blockedreason",
        new string[1]
        {
          "blockinfo"
        }
      },
      {
        "blockedexpiry",
        new string[1]
        {
          "blockinfo"
        }
      },
      {
        "hidden",
        new string[1]
        {
          "blockinfo"
        }
      },
      {
        "editcount",
        new string[1]
        {
          "editcount"
        }
      },
      {
        "registration",
        new string[1]
        {
          "registration"
        }
      }
    };
    private static readonly QueryTypeProperties<allusersSelect> allusersProperties = new QueryTypeProperties<allusersSelect>("allusers", "au", new QueryType?(QueryType.List), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "allusers"
      }
    }, QueryAction.allusersProps, new Func<XElement, WikiInfo, allusersSelect>(allusersSelect.Parse));
    private static readonly IDictionary<string, string[]> backlinksProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "pageid",
        new string[1]
        {
          ""
        }
      },
      {
        "ns",
        new string[1]
        {
          ""
        }
      },
      {
        "title",
        new string[1]
        {
          ""
        }
      },
      {
        "redirect",
        new string[1]
        {
          ""
        }
      }
    };
    private static readonly QueryTypeProperties<backlinksSelect> backlinksProperties = new QueryTypeProperties<backlinksSelect>("backlinks", "bl", new QueryType?(QueryType.List), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "backlinks"
      }
    }, QueryAction.backlinksProps, new Func<XElement, WikiInfo, backlinksSelect>(backlinksSelect.Parse));
    private static readonly IDictionary<string, string[]> blocksProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "id",
        new string[1]
        {
          "id"
        }
      },
      {
        "user",
        new string[1]
        {
          "user"
        }
      },
      {
        "userid",
        new string[1]
        {
          "userid"
        }
      },
      {
        "by",
        new string[1]
        {
          "by"
        }
      },
      {
        "byid",
        new string[1]
        {
          "byid"
        }
      },
      {
        "timestamp",
        new string[1]
        {
          "timestamp"
        }
      },
      {
        "expiry",
        new string[1]
        {
          "expiry"
        }
      },
      {
        "reason",
        new string[1]
        {
          "reason"
        }
      },
      {
        "rangestart",
        new string[1]
        {
          "range"
        }
      },
      {
        "rangeend",
        new string[1]
        {
          "range"
        }
      },
      {
        "automatic",
        new string[1]
        {
          "flags"
        }
      },
      {
        "anononly",
        new string[1]
        {
          "flags"
        }
      },
      {
        "nocreate",
        new string[1]
        {
          "flags"
        }
      },
      {
        "autoblock",
        new string[1]
        {
          "flags"
        }
      },
      {
        "noemail",
        new string[1]
        {
          "flags"
        }
      },
      {
        "hidden",
        new string[1]
        {
          "flags"
        }
      },
      {
        "allowusertalk",
        new string[1]
        {
          "flags"
        }
      }
    };
    private static readonly QueryTypeProperties<blocksSelect> blocksProperties = new QueryTypeProperties<blocksSelect>("blocks", "bk", new QueryType?(QueryType.List), new SortType?(SortType.Newer), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "blocks"
      }
    }, QueryAction.blocksProps, new Func<XElement, WikiInfo, blocksSelect>(blocksSelect.Parse));
    private static readonly IDictionary<string, string[]> categorymembersProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "pageid",
        new string[1]
        {
          "ids"
        }
      },
      {
        "ns",
        new string[1]
        {
          "title"
        }
      },
      {
        "title",
        new string[1]
        {
          "title"
        }
      },
      {
        "sortkey",
        new string[1]
        {
          "sortkey"
        }
      },
      {
        "sortkeyprefix",
        new string[1]
        {
          "sortkeyprefix"
        }
      },
      {
        "type",
        new string[1]
        {
          "type"
        }
      },
      {
        "timestamp",
        new string[1]
        {
          "timestamp"
        }
      }
    };
    private static readonly QueryTypeProperties<categorymembersSelect> categorymembersProperties = new QueryTypeProperties<categorymembersSelect>("categorymembers", "cm", new QueryType?(QueryType.List), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "categorymembers"
      }
    }, QueryAction.categorymembersProps, new Func<XElement, WikiInfo, categorymembersSelect>(categorymembersSelect.Parse));
    private static readonly IDictionary<string, string[]> deletedrevsProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "ns",
        new string[1]
        {
          ""
        }
      },
      {
        "title",
        new string[1]
        {
          ""
        }
      },
      {
        "token",
        new string[1]
        {
          "token"
        }
      }
    };
    private static readonly QueryTypeProperties<deletedrevsSelect> deletedrevsProperties = new QueryTypeProperties<deletedrevsSelect>("deletedrevs", "dr", new QueryType?(QueryType.List), new SortType?(SortType.Newer), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "deletedrevs"
      }
    }, QueryAction.deletedrevsProps, new Func<XElement, WikiInfo, deletedrevsSelect>(deletedrevsSelect.Parse));
    private static readonly IDictionary<string, string[]> embeddedinProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "pageid",
        new string[1]
        {
          ""
        }
      },
      {
        "ns",
        new string[1]
        {
          ""
        }
      },
      {
        "title",
        new string[1]
        {
          ""
        }
      },
      {
        "redirect",
        new string[1]
        {
          ""
        }
      }
    };
    private static readonly QueryTypeProperties<embeddedinSelect> embeddedinProperties = new QueryTypeProperties<embeddedinSelect>("embeddedin", "ei", new QueryType?(QueryType.List), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "embeddedin"
      }
    }, QueryAction.embeddedinProps, new Func<XElement, WikiInfo, embeddedinSelect>(embeddedinSelect.Parse));
    private static readonly IDictionary<string, string[]> exturlusageProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "pageid",
        new string[1]
        {
          "ids"
        }
      },
      {
        "ns",
        new string[1]
        {
          "title"
        }
      },
      {
        "title",
        new string[1]
        {
          "title"
        }
      },
      {
        "url",
        new string[1]
        {
          "url"
        }
      }
    };
    private static readonly QueryTypeProperties<exturlusageSelect> exturlusageProperties = new QueryTypeProperties<exturlusageSelect>("exturlusage", "eu", new QueryType?(QueryType.List), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "exturlusage"
      }
    }, QueryAction.exturlusageProps, new Func<XElement, WikiInfo, exturlusageSelect>(exturlusageSelect.Parse));
    private static readonly IDictionary<string, string[]> filearchiveProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "name",
        new string[1]
        {
          ""
        }
      },
      {
        "ns",
        new string[1]
        {
          ""
        }
      },
      {
        "title",
        new string[1]
        {
          ""
        }
      },
      {
        "filehidden",
        new string[1]
        {
          ""
        }
      },
      {
        "commenthidden",
        new string[1]
        {
          ""
        }
      },
      {
        "userhidden",
        new string[1]
        {
          ""
        }
      },
      {
        "suppressed",
        new string[1]
        {
          ""
        }
      },
      {
        "sha1",
        new string[1]
        {
          "sha1"
        }
      },
      {
        "timestamp",
        new string[1]
        {
          "timestamp"
        }
      },
      {
        "userid",
        new string[1]
        {
          "user"
        }
      },
      {
        "user",
        new string[1]
        {
          "user"
        }
      },
      {
        "size",
        new string[2]
        {
          "size",
          "dimensions"
        }
      },
      {
        "pagecount",
        new string[2]
        {
          "size",
          "dimensions"
        }
      },
      {
        "height",
        new string[2]
        {
          "size",
          "dimensions"
        }
      },
      {
        "width",
        new string[2]
        {
          "size",
          "dimensions"
        }
      },
      {
        "description",
        new string[2]
        {
          "description",
          "parseddescription"
        }
      },
      {
        "parseddescription",
        new string[1]
        {
          "parseddescription"
        }
      },
      {
        "metadata",
        new string[1]
        {
          "metadata"
        }
      },
      {
        "bitdepth",
        new string[1]
        {
          "bitdepth"
        }
      },
      {
        "mime",
        new string[1]
        {
          "mime"
        }
      },
      {
        "mediatype",
        new string[1]
        {
          "mediatype"
        }
      },
      {
        "archivename",
        new string[1]
        {
          "archivename"
        }
      }
    };
    private static readonly QueryTypeProperties<filearchiveSelect> filearchiveProperties = new QueryTypeProperties<filearchiveSelect>("filearchive", "fa", new QueryType?(QueryType.List), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "filearchive"
      }
    }, QueryAction.filearchiveProps, new Func<XElement, WikiInfo, filearchiveSelect>(filearchiveSelect.Parse));
    private static readonly IDictionary<string, string[]> imageusageProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "pageid",
        new string[1]
        {
          ""
        }
      },
      {
        "ns",
        new string[1]
        {
          ""
        }
      },
      {
        "title",
        new string[1]
        {
          ""
        }
      },
      {
        "redirect",
        new string[1]
        {
          ""
        }
      }
    };
    private static readonly QueryTypeProperties<imageusageSelect> imageusageProperties = new QueryTypeProperties<imageusageSelect>("imageusage", "iu", new QueryType?(QueryType.List), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "imageusage"
      }
    }, QueryAction.imageusageProps, new Func<XElement, WikiInfo, imageusageSelect>(imageusageSelect.Parse));
    private static readonly IDictionary<string, string[]> iwbacklinksProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "pageid",
        new string[1]
        {
          ""
        }
      },
      {
        "ns",
        new string[1]
        {
          ""
        }
      },
      {
        "title",
        new string[1]
        {
          ""
        }
      },
      {
        "redirect",
        new string[1]
        {
          ""
        }
      },
      {
        "iwprefix",
        new string[1]
        {
          "iwprefix"
        }
      },
      {
        "iwtitle",
        new string[1]
        {
          "iwtitle"
        }
      }
    };
    private static readonly QueryTypeProperties<iwbacklinksSelect> iwbacklinksProperties = new QueryTypeProperties<iwbacklinksSelect>("iwbacklinks", "iwbl", new QueryType?(QueryType.List), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "iwbacklinks"
      }
    }, QueryAction.iwbacklinksProps, new Func<XElement, WikiInfo, iwbacklinksSelect>(iwbacklinksSelect.Parse));
    private static readonly IDictionary<string, string[]> langbacklinksProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "pageid",
        new string[1]
        {
          ""
        }
      },
      {
        "ns",
        new string[1]
        {
          ""
        }
      },
      {
        "title",
        new string[1]
        {
          ""
        }
      },
      {
        "redirect",
        new string[1]
        {
          ""
        }
      },
      {
        "lllang",
        new string[1]
        {
          "lllang"
        }
      },
      {
        "lltitle",
        new string[1]
        {
          "lltitle"
        }
      }
    };
    private static readonly QueryTypeProperties<langbacklinksSelect> langbacklinksProperties = new QueryTypeProperties<langbacklinksSelect>("langbacklinks", "lbl", new QueryType?(QueryType.List), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "langbacklinks"
      }
    }, QueryAction.langbacklinksProps, new Func<XElement, WikiInfo, langbacklinksSelect>(langbacklinksSelect.Parse));
    private static readonly IDictionary<string, string[]> logeventsProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "logid",
        new string[1]
        {
          "ids"
        }
      },
      {
        "pageid",
        new string[1]
        {
          "ids"
        }
      },
      {
        "ns",
        new string[1]
        {
          "title"
        }
      },
      {
        "title",
        new string[1]
        {
          "title"
        }
      },
      {
        "type",
        new string[1]
        {
          "type"
        }
      },
      {
        "action",
        new string[1]
        {
          "type"
        }
      },
      {
        "actionhidden",
        new string[1]
        {
          "details"
        }
      },
      {
        "userhidden",
        new string[2]
        {
          "user",
          "userid"
        }
      },
      {
        "user",
        new string[1]
        {
          "user"
        }
      },
      {
        "anon",
        new string[2]
        {
          "user",
          "userid"
        }
      },
      {
        "userid",
        new string[1]
        {
          "userid"
        }
      },
      {
        "timestamp",
        new string[1]
        {
          "timestamp"
        }
      },
      {
        "commenthidden",
        new string[2]
        {
          "comment",
          "parsedcomment"
        }
      },
      {
        "comment",
        new string[1]
        {
          "comment"
        }
      },
      {
        "parsedcomment",
        new string[1]
        {
          "parsedcomment"
        }
      }
    };
    private static readonly QueryTypeProperties<logeventsSelect> logeventsProperties = new QueryTypeProperties<logeventsSelect>("logevents", "le", new QueryType?(QueryType.List), new SortType?(SortType.Newer), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "logevents"
      }
    }, QueryAction.logeventsProps, new Func<XElement, WikiInfo, logeventsSelect>(logeventsSelect.Parse));
    private static readonly IDictionary<string, string[]> protectedtitlesProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "ns",
        new string[1]
        {
          ""
        }
      },
      {
        "title",
        new string[1]
        {
          ""
        }
      },
      {
        "timestamp",
        new string[1]
        {
          "timestamp"
        }
      },
      {
        "user",
        new string[1]
        {
          "user"
        }
      },
      {
        "userid",
        new string[2]
        {
          "user",
          "userid"
        }
      },
      {
        "comment",
        new string[1]
        {
          "comment"
        }
      },
      {
        "parsedcomment",
        new string[1]
        {
          "parsedcomment"
        }
      },
      {
        "expiry",
        new string[1]
        {
          "expiry"
        }
      },
      {
        "level",
        new string[1]
        {
          "level"
        }
      }
    };
    private static readonly QueryTypeProperties<protectedtitlesSelect> protectedtitlesProperties = new QueryTypeProperties<protectedtitlesSelect>("protectedtitles", "pt", new QueryType?(QueryType.List), new SortType?(SortType.Newer), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "protectedtitles"
      }
    }, QueryAction.protectedtitlesProps, new Func<XElement, WikiInfo, protectedtitlesSelect>(protectedtitlesSelect.Parse));
    private static readonly IDictionary<string, string[]> querypageProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "value",
        new string[1]
        {
          ""
        }
      },
      {
        "timestamp",
        new string[1]
        {
          ""
        }
      },
      {
        "ns",
        new string[1]
        {
          ""
        }
      },
      {
        "title",
        new string[1]
        {
          ""
        }
      }
    };
    private static readonly QueryTypeProperties<querypageSelect> querypageProperties = new QueryTypeProperties<querypageSelect>("querypage", "qp", new QueryType?(QueryType.List), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "querypage"
      }
    }, QueryAction.querypageProps, new Func<XElement, WikiInfo, querypageSelect>(querypageSelect.Parse));
    private static readonly IDictionary<string, string[]> randomProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "id",
        new string[1]
        {
          ""
        }
      },
      {
        "ns",
        new string[1]
        {
          ""
        }
      },
      {
        "title",
        new string[1]
        {
          ""
        }
      }
    };
    private static readonly QueryTypeProperties<randomSelect> randomProperties = new QueryTypeProperties<randomSelect>("random", "rn", new QueryType?(QueryType.List), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "random"
      }
    }, QueryAction.randomProps, new Func<XElement, WikiInfo, randomSelect>(randomSelect.Parse));
    private static readonly IDictionary<string, string[]> recentchangesProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "type",
        new string[1]
        {
          ""
        }
      },
      {
        "patroltoken",
        new string[1]
        {
          ""
        }
      },
      {
        "ns",
        new string[1]
        {
          "title"
        }
      },
      {
        "title",
        new string[1]
        {
          "title"
        }
      },
      {
        "new_ns",
        new string[1]
        {
          "title"
        }
      },
      {
        "new_title",
        new string[1]
        {
          "title"
        }
      },
      {
        "rcid",
        new string[1]
        {
          "ids"
        }
      },
      {
        "pageid",
        new string[1]
        {
          "ids"
        }
      },
      {
        "revid",
        new string[1]
        {
          "ids"
        }
      },
      {
        "old_revid",
        new string[1]
        {
          "ids"
        }
      },
      {
        "user",
        new string[1]
        {
          "user"
        }
      },
      {
        "anon",
        new string[2]
        {
          "user",
          "userid"
        }
      },
      {
        "userid",
        new string[1]
        {
          "userid"
        }
      },
      {
        "bot",
        new string[1]
        {
          "flags"
        }
      },
      {
        "new",
        new string[1]
        {
          "flags"
        }
      },
      {
        "minor",
        new string[1]
        {
          "flags"
        }
      },
      {
        "oldlen",
        new string[1]
        {
          "sizes"
        }
      },
      {
        "newlen",
        new string[1]
        {
          "sizes"
        }
      },
      {
        "timestamp",
        new string[1]
        {
          "timestamp"
        }
      },
      {
        "comment",
        new string[1]
        {
          "comment"
        }
      },
      {
        "parsedcomment",
        new string[1]
        {
          "parsedcomment"
        }
      },
      {
        "redirect",
        new string[1]
        {
          "redirect"
        }
      },
      {
        "patrolled",
        new string[1]
        {
          "patrolled"
        }
      },
      {
        "logid",
        new string[1]
        {
          "loginfo"
        }
      },
      {
        "logtype",
        new string[1]
        {
          "loginfo"
        }
      },
      {
        "logaction",
        new string[1]
        {
          "loginfo"
        }
      },
      {
        "sha1",
        new string[1]
        {
          "sha1"
        }
      },
      {
        "sha1hidden",
        new string[1]
        {
          "sha1"
        }
      }
    };
    private static readonly QueryTypeProperties<recentchangesSelect> recentchangesProperties = new QueryTypeProperties<recentchangesSelect>("recentchanges", "rc", new QueryType?(QueryType.List), new SortType?(SortType.Newer), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "recentchanges"
      }
    }, QueryAction.recentchangesProps, new Func<XElement, WikiInfo, recentchangesSelect>(recentchangesSelect.Parse));
    private static readonly IDictionary<string, string[]> searchProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "ns",
        new string[1]
        {
          ""
        }
      },
      {
        "title",
        new string[1]
        {
          ""
        }
      },
      {
        "snippet",
        new string[1]
        {
          "snippet"
        }
      },
      {
        "size",
        new string[1]
        {
          "size"
        }
      },
      {
        "wordcount",
        new string[1]
        {
          "wordcount"
        }
      },
      {
        "timestamp",
        new string[1]
        {
          "timestamp"
        }
      },
      {
        "score",
        new string[1]
        {
          "score"
        }
      },
      {
        "titlesnippet",
        new string[1]
        {
          "titlesnippet"
        }
      },
      {
        "redirecttitle",
        new string[1]
        {
          "redirecttitle"
        }
      },
      {
        "redirectsnippet",
        new string[1]
        {
          "redirectsnippet"
        }
      },
      {
        "sectiontitle",
        new string[1]
        {
          "sectiontitle"
        }
      },
      {
        "sectionsnippet",
        new string[1]
        {
          "sectionsnippet"
        }
      },
      {
        "hasrelated",
        new string[1]
        {
          "hasrelated"
        }
      }
    };
    private static readonly QueryTypeProperties<searchSelect> searchProperties = new QueryTypeProperties<searchSelect>("search", "sr", new QueryType?(QueryType.List), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "search"
      }
    }, QueryAction.searchProps, new Func<XElement, WikiInfo, searchSelect>(searchSelect.Parse));
    private static readonly IDictionary<string, string[]> tagsProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "name",
        new string[1]
        {
          ""
        }
      },
      {
        "displayname",
        new string[1]
        {
          "displayname"
        }
      },
      {
        "description",
        new string[1]
        {
          "description"
        }
      },
      {
        "hitcount",
        new string[1]
        {
          "hitcount"
        }
      }
    };
    private static readonly QueryTypeProperties<tagsSelect> tagsProperties = new QueryTypeProperties<tagsSelect>("tags", "tg", new QueryType?(QueryType.List), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "tags"
      }
    }, QueryAction.tagsProps, new Func<XElement, WikiInfo, tagsSelect>(tagsSelect.Parse));
    private static readonly IDictionary<string, string[]> usercontribsProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "userid",
        new string[1]
        {
          ""
        }
      },
      {
        "user",
        new string[1]
        {
          ""
        }
      },
      {
        "userhidden",
        new string[1]
        {
          ""
        }
      },
      {
        "pageid",
        new string[1]
        {
          "ids"
        }
      },
      {
        "revid",
        new string[1]
        {
          "ids"
        }
      },
      {
        "parentid",
        new string[1]
        {
          "ids"
        }
      },
      {
        "ns",
        new string[1]
        {
          "title"
        }
      },
      {
        "title",
        new string[1]
        {
          "title"
        }
      },
      {
        "timestamp",
        new string[1]
        {
          "timestamp"
        }
      },
      {
        "new",
        new string[1]
        {
          "flags"
        }
      },
      {
        "minor",
        new string[1]
        {
          "flags"
        }
      },
      {
        "top",
        new string[1]
        {
          "flags"
        }
      },
      {
        "commenthidden",
        new string[2]
        {
          "comment",
          "parsedcomment"
        }
      },
      {
        "comment",
        new string[1]
        {
          "comment"
        }
      },
      {
        "parsedcomment",
        new string[1]
        {
          "parsedcomment"
        }
      },
      {
        "patrolled",
        new string[1]
        {
          "patrolled"
        }
      },
      {
        "size",
        new string[1]
        {
          "size"
        }
      },
      {
        "sizediff",
        new string[1]
        {
          "sizediff"
        }
      }
    };
    private static readonly QueryTypeProperties<usercontribsSelect> usercontribsProperties = new QueryTypeProperties<usercontribsSelect>("usercontribs", "uc", new QueryType?(QueryType.List), new SortType?(SortType.Newer), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "usercontribs"
      }
    }, QueryAction.usercontribsProps, new Func<XElement, WikiInfo, usercontribsSelect>(usercontribsSelect.Parse));
    private static readonly QueryTypeProperties<userinfoResult> userinfoProperties = new QueryTypeProperties<userinfoResult>("userinfo", "ui", new QueryType?(QueryType.Meta), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "meta",
        "userinfo"
      },
      {
        "uiprop",
        "blockinfo|hasmsg|preferencestoken|editcount|realname|email|registrationdate"
      }
    }, (IDictionary<string, string[]>) null, new Func<XElement, WikiInfo, userinfoResult>(userinfoResult.Parse));
    private static readonly IDictionary<string, string[]> usersProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "userid",
        new string[1]
        {
          ""
        }
      },
      {
        "name",
        new string[1]
        {
          ""
        }
      },
      {
        "invalid",
        new string[1]
        {
          ""
        }
      },
      {
        "hidden",
        new string[1]
        {
          ""
        }
      },
      {
        "interwiki",
        new string[1]
        {
          ""
        }
      },
      {
        "missing",
        new string[1]
        {
          ""
        }
      },
      {
        "userrightstoken",
        new string[1]
        {
          ""
        }
      },
      {
        "editcount",
        new string[1]
        {
          "editcount"
        }
      },
      {
        "registration",
        new string[1]
        {
          "registration"
        }
      },
      {
        "blockid",
        new string[1]
        {
          "blockinfo"
        }
      },
      {
        "blockedby",
        new string[1]
        {
          "blockinfo"
        }
      },
      {
        "blockedbyid",
        new string[1]
        {
          "blockinfo"
        }
      },
      {
        "blockedreason",
        new string[1]
        {
          "blockinfo"
        }
      },
      {
        "blockedexpiry",
        new string[1]
        {
          "blockinfo"
        }
      },
      {
        "emailable",
        new string[1]
        {
          "emailable"
        }
      },
      {
        "gender",
        new string[1]
        {
          "gender"
        }
      }
    };
    private static readonly QueryTypeProperties<usersSelect> usersProperties = new QueryTypeProperties<usersSelect>("users", "us", new QueryType?(QueryType.List), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "users"
      }
    }, QueryAction.usersProps, new Func<XElement, WikiInfo, usersSelect>(usersSelect.Parse));
    private static readonly IDictionary<string, string[]> watchlistProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "type",
        new string[1]
        {
          ""
        }
      },
      {
        "pageid",
        new string[1]
        {
          "ids"
        }
      },
      {
        "revid",
        new string[1]
        {
          "ids"
        }
      },
      {
        "old_revid",
        new string[1]
        {
          "ids"
        }
      },
      {
        "ns",
        new string[1]
        {
          "title"
        }
      },
      {
        "title",
        new string[1]
        {
          "title"
        }
      },
      {
        "user",
        new string[1]
        {
          "user"
        }
      },
      {
        "anon",
        new string[2]
        {
          "user",
          "userid"
        }
      },
      {
        "userid",
        new string[1]
        {
          "userid"
        }
      },
      {
        "new",
        new string[1]
        {
          "flags"
        }
      },
      {
        "minor",
        new string[1]
        {
          "flags"
        }
      },
      {
        "bot",
        new string[1]
        {
          "flags"
        }
      },
      {
        "patrolled",
        new string[1]
        {
          "patrol"
        }
      },
      {
        "timestamp",
        new string[1]
        {
          "timestamp"
        }
      },
      {
        "oldlen",
        new string[1]
        {
          "sizes"
        }
      },
      {
        "newlen",
        new string[1]
        {
          "sizes"
        }
      },
      {
        "notificationtimestamp",
        new string[1]
        {
          "notificationtimestamp"
        }
      },
      {
        "comment",
        new string[1]
        {
          "comment"
        }
      },
      {
        "parsedcomment",
        new string[1]
        {
          "parsedcomment"
        }
      },
      {
        "logid",
        new string[1]
        {
          "loginfo"
        }
      },
      {
        "logtype",
        new string[1]
        {
          "loginfo"
        }
      },
      {
        "logaction",
        new string[1]
        {
          "loginfo"
        }
      }
    };
    private static readonly QueryTypeProperties<watchlistSelect> watchlistProperties = new QueryTypeProperties<watchlistSelect>("watchlist", "wl", new QueryType?(QueryType.List), new SortType?(SortType.Newer), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "watchlist"
      }
    }, QueryAction.watchlistProps, new Func<XElement, WikiInfo, watchlistSelect>(watchlistSelect.Parse));
    private static readonly IDictionary<string, string[]> watchlistrawProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "ns",
        new string[1]
        {
          ""
        }
      },
      {
        "title",
        new string[1]
        {
          ""
        }
      },
      {
        "changed",
        new string[1]
        {
          "changed"
        }
      }
    };
    private static readonly QueryTypeProperties<watchlistrawSelect> watchlistrawProperties = new QueryTypeProperties<watchlistrawSelect>("watchlistraw", "wr", new QueryType?(QueryType.List), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>()
    {
      {
        "action",
        "query"
      },
      {
        "list",
        "watchlistraw"
      }
    }, QueryAction.watchlistrawProps, new Func<XElement, WikiInfo, watchlistrawSelect>(watchlistrawSelect.Parse));
    private readonly WikiInfo m_wiki;

    internal QueryAction(WikiInfo wiki)
    {
      this.m_wiki = wiki;
    }

    /// <summary>
    /// Enumerate all categories
    /// 
    /// </summary>
    public WikiQuerySortableGenerator<Page, allcategoriesWhere, allcategoriesOrderBy, allcategoriesSelect> allcategories()
    {
      QueryParameters<allcategoriesSelect, allcategoriesSelect> parameters = QueryParameters.Create<allcategoriesSelect>();
      return new WikiQuerySortableGenerator<Page, allcategoriesWhere, allcategoriesOrderBy, allcategoriesSelect>(new QueryProcessor<allcategoriesSelect>(this.m_wiki, QueryAction.allcategoriesProperties), parameters);
    }

    /// <summary>
    /// Enumerate all images sequentially
    /// 
    /// </summary>
    public WikiQuerySortableGenerator<Page, allimagesWhere, allimagesOrderBy, allimagesSelect> allimages()
    {
      QueryParameters<allimagesSelect, allimagesSelect> parameters = QueryParameters.Create<allimagesSelect>();
      return new WikiQuerySortableGenerator<Page, allimagesWhere, allimagesOrderBy, allimagesSelect>(new QueryProcessor<allimagesSelect>(this.m_wiki, QueryAction.allimagesProperties), parameters);
    }

    /// <summary>
    /// Enumerate all links that point to a given namespace
    /// 
    /// </summary>
    public WikiQuerySortableGenerator<Page, alllinksWhere, alllinksOrderBy, alllinksSelect> alllinks()
    {
      QueryParameters<alllinksSelect, alllinksSelect> parameters = QueryParameters.Create<alllinksSelect>();
      return new WikiQuerySortableGenerator<Page, alllinksWhere, alllinksOrderBy, alllinksSelect>(new QueryProcessor<alllinksSelect>(this.m_wiki, QueryAction.alllinksProperties), parameters);
    }

    /// <summary>
    /// Return messages from this site
    /// 
    /// </summary>
    public WikiQuery<allmessagesWhere, allmessagesSelect> allmessages()
    {
      QueryParameters<allmessagesSelect, allmessagesSelect> parameters = QueryParameters.Create<allmessagesSelect>();
      return new WikiQuery<allmessagesWhere, allmessagesSelect>(new QueryProcessor<allmessagesSelect>(this.m_wiki, QueryAction.allmessagesProperties), parameters);
    }

    /// <summary>
    /// Enumerate all pages sequentially in a given namespace
    /// 
    /// </summary>
    public WikiQuerySortableGenerator<Page, allpagesWhere, allpagesOrderBy, allpagesSelect> allpages()
    {
      QueryParameters<allpagesSelect, allpagesSelect> parameters = QueryParameters.Create<allpagesSelect>();
      return new WikiQuerySortableGenerator<Page, allpagesWhere, allpagesOrderBy, allpagesSelect>(new QueryProcessor<allpagesSelect>(this.m_wiki, QueryAction.allpagesProperties), parameters);
    }

    /// <summary>
    /// List all transclusions (pages embedded using {{x}}), including non-existing
    /// 
    /// </summary>
    public WikiQuerySortableGenerator<Page, alltransclusionsWhere, alltransclusionsOrderBy, alltransclusionsSelect> alltransclusions()
    {
      QueryParameters<alltransclusionsSelect, alltransclusionsSelect> parameters = QueryParameters.Create<alltransclusionsSelect>();
      return new WikiQuerySortableGenerator<Page, alltransclusionsWhere, alltransclusionsOrderBy, alltransclusionsSelect>(new QueryProcessor<alltransclusionsSelect>(this.m_wiki, QueryAction.alltransclusionsProperties), parameters);
    }

    /// <summary>
    /// Enumerate all registered users
    /// 
    /// </summary>
    public WikiQuerySortable<allusersWhere, allusersOrderBy, allusersSelect> allusers()
    {
      QueryParameters<allusersSelect, allusersSelect> parameters = QueryParameters.Create<allusersSelect>();
      return new WikiQuerySortable<allusersWhere, allusersOrderBy, allusersSelect>(new QueryProcessor<allusersSelect>(this.m_wiki, QueryAction.allusersProperties), parameters);
    }

    /// <summary>
    /// Find all pages that link to the given page
    /// 
    /// </summary>
    public WikiQuerySortableGenerator<Page, backlinksWhere, backlinksOrderBy, backlinksSelect> backlinks()
    {
      QueryParameters<backlinksSelect, backlinksSelect> parameters = QueryParameters.Create<backlinksSelect>();
      return new WikiQuerySortableGenerator<Page, backlinksWhere, backlinksOrderBy, backlinksSelect>(new QueryProcessor<backlinksSelect>(this.m_wiki, QueryAction.backlinksProperties), parameters);
    }

    /// <summary>
    /// List all blocked users and IP addresses
    /// 
    /// </summary>
    public WikiQuerySortable<blocksWhere, blocksOrderBy, blocksSelect> blocks()
    {
      QueryParameters<blocksSelect, blocksSelect> parameters = QueryParameters.Create<blocksSelect>();
      return new WikiQuerySortable<blocksWhere, blocksOrderBy, blocksSelect>(new QueryProcessor<blocksSelect>(this.m_wiki, QueryAction.blocksProperties), parameters);
    }

    /// <summary>
    /// List all pages in a given category
    /// 
    /// </summary>
    public WikiQuerySortableGenerator<Page, categorymembersWhere, categorymembersOrderBy, categorymembersSelect> categorymembers()
    {
      QueryParameters<categorymembersSelect, categorymembersSelect> parameters = QueryParameters.Create<categorymembersSelect>();
      return new WikiQuerySortableGenerator<Page, categorymembersWhere, categorymembersOrderBy, categorymembersSelect>(new QueryProcessor<categorymembersSelect>(this.m_wiki, QueryAction.categorymembersProperties), parameters);
    }

    /// <summary>
    /// List deleted revisions.
    ///             Operates in three modes:
    ///              1) List deleted revisions for the given title(s), sorted by timestamp
    ///              2) List deleted contributions for the given user, sorted by timestamp (no titles specified)
    ///              3) List all deleted revisions in the given namespace, sorted by title and timestamp (no titles specified, druser not set)
    ///             Certain parameters only apply to some modes and are ignored in others.
    ///             For instance, a parameter marked (1) only applies to mode 1 and is ignored in modes 2 and 3
    /// 
    /// </summary>
    public WikiQuerySortable<deletedrevsWhere, deletedrevsOrderBy, deletedrevsSelect> deletedrevs()
    {
      QueryParameters<deletedrevsSelect, deletedrevsSelect> parameters = QueryParameters.Create<deletedrevsSelect>();
      return new WikiQuerySortable<deletedrevsWhere, deletedrevsOrderBy, deletedrevsSelect>(new QueryProcessor<deletedrevsSelect>(this.m_wiki, QueryAction.deletedrevsProperties), parameters);
    }

    /// <summary>
    /// Find all pages that embed (transclude) the given title
    /// 
    /// </summary>
    public WikiQuerySortableGenerator<Page, embeddedinWhere, embeddedinOrderBy, embeddedinSelect> embeddedin()
    {
      QueryParameters<embeddedinSelect, embeddedinSelect> parameters = QueryParameters.Create<embeddedinSelect>();
      return new WikiQuerySortableGenerator<Page, embeddedinWhere, embeddedinOrderBy, embeddedinSelect>(new QueryProcessor<embeddedinSelect>(this.m_wiki, QueryAction.embeddedinProperties), parameters);
    }

    /// <summary>
    /// Enumerate pages that contain a given URL
    /// 
    /// </summary>
    public WikiQueryGenerator<Page, exturlusageWhere, exturlusageSelect> exturlusage()
    {
      QueryParameters<exturlusageSelect, exturlusageSelect> parameters = QueryParameters.Create<exturlusageSelect>();
      return new WikiQueryGenerator<Page, exturlusageWhere, exturlusageSelect>(new QueryProcessor<exturlusageSelect>(this.m_wiki, QueryAction.exturlusageProperties), parameters);
    }

    /// <summary>
    /// Enumerate all deleted files sequentially
    /// 
    /// </summary>
    public WikiQuerySortable<filearchiveWhere, filearchiveOrderBy, filearchiveSelect> filearchive()
    {
      QueryParameters<filearchiveSelect, filearchiveSelect> parameters = QueryParameters.Create<filearchiveSelect>();
      return new WikiQuerySortable<filearchiveWhere, filearchiveOrderBy, filearchiveSelect>(new QueryProcessor<filearchiveSelect>(this.m_wiki, QueryAction.filearchiveProperties), parameters);
    }

    /// <summary>
    /// Find all pages that use the given image title.
    /// 
    /// </summary>
    public WikiQuerySortableGenerator<Page, imageusageWhere, imageusageOrderBy, imageusageSelect> imageusage()
    {
      QueryParameters<imageusageSelect, imageusageSelect> parameters = QueryParameters.Create<imageusageSelect>();
      return new WikiQuerySortableGenerator<Page, imageusageWhere, imageusageOrderBy, imageusageSelect>(new QueryProcessor<imageusageSelect>(this.m_wiki, QueryAction.imageusageProperties), parameters);
    }

    /// <summary>
    /// Find all pages that link to the given interwiki link.
    ///             Can be used to find all links with a prefix, or
    ///             all links to a title (with a given prefix).
    ///             Using neither parameter is effectively "All IW Links"
    /// 
    /// </summary>
    public WikiQuerySortableGenerator<Page, iwbacklinksWhere, iwbacklinksOrderBy, iwbacklinksSelect> iwbacklinks()
    {
      QueryParameters<iwbacklinksSelect, iwbacklinksSelect> parameters = QueryParameters.Create<iwbacklinksSelect>();
      return new WikiQuerySortableGenerator<Page, iwbacklinksWhere, iwbacklinksOrderBy, iwbacklinksSelect>(new QueryProcessor<iwbacklinksSelect>(this.m_wiki, QueryAction.iwbacklinksProperties), parameters);
    }

    /// <summary>
    /// Find all pages that link to the given language link.
    ///             Can be used to find all links with a language code, or
    ///             all links to a title (with a given language).
    ///             Using neither parameter is effectively "All Language Links".
    ///             Note that this may not consider language links added by extensions.
    /// 
    /// </summary>
    public WikiQuerySortableGenerator<Page, langbacklinksWhere, langbacklinksOrderBy, langbacklinksSelect> langbacklinks()
    {
      QueryParameters<langbacklinksSelect, langbacklinksSelect> parameters = QueryParameters.Create<langbacklinksSelect>();
      return new WikiQuerySortableGenerator<Page, langbacklinksWhere, langbacklinksOrderBy, langbacklinksSelect>(new QueryProcessor<langbacklinksSelect>(this.m_wiki, QueryAction.langbacklinksProperties), parameters);
    }

    /// <summary>
    /// Get events from logs
    /// 
    /// </summary>
    public WikiQuerySortable<logeventsWhere, logeventsOrderBy, logeventsSelect> logevents()
    {
      QueryParameters<logeventsSelect, logeventsSelect> parameters = QueryParameters.Create<logeventsSelect>();
      return new WikiQuerySortable<logeventsWhere, logeventsOrderBy, logeventsSelect>(new QueryProcessor<logeventsSelect>(this.m_wiki, QueryAction.logeventsProperties), parameters);
    }

    /// <summary>
    /// List all titles protected from creation
    /// 
    /// </summary>
    public WikiQuerySortableGenerator<Page, protectedtitlesWhere, protectedtitlesOrderBy, protectedtitlesSelect> protectedtitles()
    {
      QueryParameters<protectedtitlesSelect, protectedtitlesSelect> parameters = QueryParameters.Create<protectedtitlesSelect>();
      return new WikiQuerySortableGenerator<Page, protectedtitlesWhere, protectedtitlesOrderBy, protectedtitlesSelect>(new QueryProcessor<protectedtitlesSelect>(this.m_wiki, QueryAction.protectedtitlesProperties), parameters);
    }

    /// <summary>
    /// Get a list provided by a QueryPage-based special page
    /// 
    /// </summary>
    /// <param name="page">The name of the special page. Note, this is case sensitive
    ///             </param>
    public WikiQueryGenerator<Page, querypageWhere, querypageSelect> querypage(querypagepage page)
    {
      QueryParameters<querypageSelect, querypageSelect> parameters = QueryParameters.Create<querypageSelect>().AddSingleValue("page", QueryRepresentation.ToQueryString((StringValue) page));
      return new WikiQueryGenerator<Page, querypageWhere, querypageSelect>(new QueryProcessor<querypageSelect>(this.m_wiki, QueryAction.querypageProperties), parameters);
    }

    /// <summary>
    /// Get a set of random pages
    ///             NOTE: Pages are listed in a fixed sequence, only the starting point is random. This means that if, for example, "Main Page" is the first
    ///                   random page on your list, "List of fictional monkeys" will *always* be second, "List of people on stamps of Vanuatu" third, etc
    ///             NOTE: If the number of pages in the namespace is lower than rnlimit, you will get fewer pages. You will not get the same page twice
    /// 
    /// </summary>
    public WikiQueryGenerator<Page, randomWhere, randomSelect> random()
    {
      QueryParameters<randomSelect, randomSelect> parameters = QueryParameters.Create<randomSelect>();
      return new WikiQueryGenerator<Page, randomWhere, randomSelect>(new QueryProcessor<randomSelect>(this.m_wiki, QueryAction.randomProperties), parameters);
    }

    /// <summary>
    /// Enumerate recent changes
    /// 
    /// </summary>
    public WikiQuerySortableGenerator<Page, recentchangesWhere, recentchangesOrderBy, recentchangesSelect> recentchanges()
    {
      QueryParameters<recentchangesSelect, recentchangesSelect> parameters = QueryParameters.Create<recentchangesSelect>();
      return new WikiQuerySortableGenerator<Page, recentchangesWhere, recentchangesOrderBy, recentchangesSelect>(new QueryProcessor<recentchangesSelect>(this.m_wiki, QueryAction.recentchangesProperties), parameters);
    }

    /// <summary>
    /// Perform a full text search
    /// 
    /// </summary>
    /// <param name="search">Search for all page titles (or content) that has this value
    ///             </param>
    public WikiQueryGenerator<Page, searchWhere, searchSelect> search(string search)
    {
      QueryParameters<searchSelect, searchSelect> parameters = QueryParameters.Create<searchSelect>().AddSingleValue("search", QueryRepresentation.ToQueryString(search));
      return new WikiQueryGenerator<Page, searchWhere, searchSelect>(new QueryProcessor<searchSelect>(this.m_wiki, QueryAction.searchProperties), parameters);
    }

    /// <summary>
    /// List change tags
    /// 
    /// </summary>
    public WikiQuery<tagsWhere, tagsSelect> tags()
    {
      QueryParameters<tagsSelect, tagsSelect> parameters = QueryParameters.Create<tagsSelect>();
      return new WikiQuery<tagsWhere, tagsSelect>(new QueryProcessor<tagsSelect>(this.m_wiki, QueryAction.tagsProperties), parameters);
    }

    /// <summary>
    /// Get all edits by a user
    /// 
    /// </summary>
    public WikiQuerySortable<usercontribsWhere, usercontribsOrderBy, usercontribsSelect> usercontribs()
    {
      QueryParameters<usercontribsSelect, usercontribsSelect> parameters = QueryParameters.Create<usercontribsSelect>();
      return new WikiQuerySortable<usercontribsWhere, usercontribsOrderBy, usercontribsSelect>(new QueryProcessor<usercontribsSelect>(this.m_wiki, QueryAction.usercontribsProperties), parameters);
    }

    /// <summary>
    /// Get information about the current user
    /// 
    /// </summary>
    public userinfoResult userinfo()
    {
      QueryParameters<userinfoResult, userinfoResult> parameters = QueryParameters.Create<userinfoResult>();
      return new QueryProcessor<userinfoResult>(this.m_wiki, QueryAction.userinfoProperties).ExecuteSingle<userinfoResult>(parameters);
    }

    /// <summary>
    /// Get information about a list of users
    /// 
    /// </summary>
    public WikiQuery<usersWhere, usersSelect> users()
    {
      QueryParameters<usersSelect, usersSelect> parameters = QueryParameters.Create<usersSelect>();
      return new WikiQuery<usersWhere, usersSelect>(new QueryProcessor<usersSelect>(this.m_wiki, QueryAction.usersProperties), parameters);
    }

    /// <summary>
    /// Get all recent changes to pages in the logged in user's watchlist
    /// 
    /// </summary>
    public WikiQuerySortableGenerator<Page, watchlistWhere, watchlistOrderBy, watchlistSelect> watchlist()
    {
      QueryParameters<watchlistSelect, watchlistSelect> parameters = QueryParameters.Create<watchlistSelect>();
      return new WikiQuerySortableGenerator<Page, watchlistWhere, watchlistOrderBy, watchlistSelect>(new QueryProcessor<watchlistSelect>(this.m_wiki, QueryAction.watchlistProperties), parameters);
    }

    /// <summary>
    /// Get all pages on the logged in user's watchlist
    /// 
    /// </summary>
    public WikiQuerySortableGenerator<Page, watchlistrawWhere, watchlistrawOrderBy, watchlistrawSelect> watchlistraw()
    {
      QueryParameters<watchlistrawSelect, watchlistrawSelect> parameters = QueryParameters.Create<watchlistrawSelect>();
      return new WikiQuerySortableGenerator<Page, watchlistrawWhere, watchlistrawOrderBy, watchlistrawSelect>(new QueryProcessor<watchlistrawSelect>(this.m_wiki, QueryAction.watchlistrawProperties), parameters);
    }
  }
}
