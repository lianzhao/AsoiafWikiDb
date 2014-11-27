// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Page
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Generated.Entities;
using LinqToWiki.Internals;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace LinqToWiki.Generated
{
  public abstract class Page
  {
    private static readonly IDictionary<string, string[]> categoriesProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
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
          "sortkey"
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
        "hidden",
        new string[1]
        {
          "hidden"
        }
      }
    };
    private static readonly QueryTypeProperties<categoriesSelect> categoriesProperties = new QueryTypeProperties<categoriesSelect>("categories", "cl", new QueryType?(QueryType.Prop), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>(), Page.categoriesProps, new Func<XElement, WikiInfo, categoriesSelect>(categoriesSelect.Parse));
    private static readonly IDictionary<string, string[]> categoryinfoProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "size",
        new string[1]
        {
          ""
        }
      },
      {
        "pages",
        new string[1]
        {
          ""
        }
      },
      {
        "files",
        new string[1]
        {
          ""
        }
      },
      {
        "subcats",
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
      }
    };
    private static readonly QueryTypeProperties<categoryinfoResult> categoryinfoProperties = new QueryTypeProperties<categoryinfoResult>("categoryinfo", "ci", new QueryType?(QueryType.Prop), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>(), Page.categoryinfoProps, new Func<XElement, WikiInfo, categoryinfoResult>(categoryinfoResult.Parse));
    private static readonly IDictionary<string, string[]> duplicatefilesProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "name",
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
        "timestamp",
        new string[1]
        {
          ""
        }
      },
      {
        "shared",
        new string[1]
        {
          ""
        }
      }
    };
    private static readonly QueryTypeProperties<duplicatefilesSelect> duplicatefilesProperties = new QueryTypeProperties<duplicatefilesSelect>("duplicatefiles", "df", new QueryType?(QueryType.Prop), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>(), Page.duplicatefilesProps, new Func<XElement, WikiInfo, duplicatefilesSelect>(duplicatefilesSelect.Parse));
    private static readonly IDictionary<string, string[]> extlinksProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "*",
        new string[1]
        {
          ""
        }
      }
    };
    private static readonly QueryTypeProperties<extlinksSelect> extlinksProperties = new QueryTypeProperties<extlinksSelect>("extlinks", "el", new QueryType?(QueryType.Prop), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>(), Page.extlinksProps, new Func<XElement, WikiInfo, extlinksSelect>(extlinksSelect.Parse));
    private static readonly IDictionary<string, string[]> imageinfoProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
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
        new string[7]
        {
          "url",
          "sha1",
          "mime",
          "thumbmime",
          "mediatype",
          "archivename",
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
        "thumbmime",
        new string[1]
        {
          "thumbmime"
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
      },
      {
        "bitdepth",
        new string[1]
        {
          "bitdepth"
        }
      }
    };
    private static readonly QueryTypeProperties<imageinfoSelect> imageinfoProperties = new QueryTypeProperties<imageinfoSelect>("imageinfo", "ii", new QueryType?(QueryType.Prop), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>(), Page.imageinfoProps, new Func<XElement, WikiInfo, imageinfoSelect>(imageinfoSelect.Parse));
    private static readonly IDictionary<string, string[]> imagesProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
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
      }
    };
    private static readonly QueryTypeProperties<imagesSelect> imagesProperties = new QueryTypeProperties<imagesSelect>("images", "im", new QueryType?(QueryType.Prop), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>(), Page.imagesProps, new Func<XElement, WikiInfo, imagesSelect>(imagesSelect.Parse));
    private static readonly IDictionary<string, string[]> infoProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
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
        "missing",
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
        "special",
        new string[1]
        {
          ""
        }
      },
      {
        "touched",
        new string[1]
        {
          ""
        }
      },
      {
        "lastrevid",
        new string[1]
        {
          ""
        }
      },
      {
        "counter",
        new string[1]
        {
          ""
        }
      },
      {
        "length",
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
        "new",
        new string[1]
        {
          ""
        }
      },
      {
        "starttimestamp",
        new string[1]
        {
          ""
        }
      },
      {
        "contentmodel",
        new string[1]
        {
          ""
        }
      },
      {
        "edittoken",
        new string[1]
        {
          ""
        }
      },
      {
        "deletetoken",
        new string[1]
        {
          ""
        }
      },
      {
        "protecttoken",
        new string[1]
        {
          ""
        }
      },
      {
        "movetoken",
        new string[1]
        {
          ""
        }
      },
      {
        "blocktoken",
        new string[1]
        {
          ""
        }
      },
      {
        "unblocktoken",
        new string[1]
        {
          ""
        }
      },
      {
        "emailtoken",
        new string[1]
        {
          ""
        }
      },
      {
        "importtoken",
        new string[1]
        {
          ""
        }
      },
      {
        "watchtoken",
        new string[1]
        {
          ""
        }
      },
      {
        "watched",
        new string[1]
        {
          "watched"
        }
      },
      {
        "watchers",
        new string[1]
        {
          "watchers"
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
        "talkid",
        new string[1]
        {
          "talkid"
        }
      },
      {
        "subjectid",
        new string[1]
        {
          "subjectid"
        }
      },
      {
        "fullurl",
        new string[1]
        {
          "url"
        }
      },
      {
        "editurl",
        new string[1]
        {
          "url"
        }
      },
      {
        "readable",
        new string[1]
        {
          "readable"
        }
      },
      {
        "preload",
        new string[1]
        {
          "preload"
        }
      },
      {
        "displaytitle",
        new string[1]
        {
          "displaytitle"
        }
      }
    };
    private static readonly QueryTypeProperties<infoResult> infoProperties = new QueryTypeProperties<infoResult>("info", "in", new QueryType?(QueryType.Prop), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>(), Page.infoProps, new Func<XElement, WikiInfo, infoResult>(infoResult.Parse));
    private static readonly IDictionary<string, string[]> iwlinksProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "prefix",
        new string[1]
        {
          ""
        }
      },
      {
        "url",
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
      }
    };
    private static readonly QueryTypeProperties<iwlinksSelect> iwlinksProperties = new QueryTypeProperties<iwlinksSelect>("iwlinks", "iw", new QueryType?(QueryType.Prop), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>(), Page.iwlinksProps, new Func<XElement, WikiInfo, iwlinksSelect>(iwlinksSelect.Parse));
    private static readonly IDictionary<string, string[]> langlinksProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "lang",
        new string[1]
        {
          ""
        }
      },
      {
        "url",
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
      }
    };
    private static readonly QueryTypeProperties<langlinksSelect> langlinksProperties = new QueryTypeProperties<langlinksSelect>("langlinks", "ll", new QueryType?(QueryType.Prop), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>(), Page.langlinksProps, new Func<XElement, WikiInfo, langlinksSelect>(langlinksSelect.Parse));
    private static readonly IDictionary<string, string[]> linksProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
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
      }
    };
    private static readonly QueryTypeProperties<linksSelect> linksProperties = new QueryTypeProperties<linksSelect>("links", "pl", new QueryType?(QueryType.Prop), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>(), Page.linksProps, new Func<XElement, WikiInfo, linksSelect>(linksSelect.Parse));
    private static readonly IDictionary<string, string[]> revisionsProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
      {
        "rollbacktoken",
        new string[1]
        {
          ""
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
        "minor",
        new string[1]
        {
          "flags"
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
        "size",
        new string[1]
        {
          "size"
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
        "*",
        new string[1]
        {
          "content"
        }
      },
      {
        "texthidden",
        new string[1]
        {
          "content"
        }
      },
      {
        "textmissing",
        new string[1]
        {
          "content"
        }
      },
      {
        "contentmodel",
        new string[1]
        {
          "contentmodel"
        }
      }
    };
    private static readonly QueryTypeProperties<revisionsSelect> revisionsProperties = new QueryTypeProperties<revisionsSelect>("revisions", "rv", new QueryType?(QueryType.Prop), new SortType?(SortType.Newer), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>(), Page.revisionsProps, new Func<XElement, WikiInfo, revisionsSelect>(revisionsSelect.Parse));
    private static readonly IDictionary<string, string[]> templatesProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
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
      }
    };
    private static readonly QueryTypeProperties<templatesSelect> templatesProperties = new QueryTypeProperties<templatesSelect>("templates", "tl", new QueryType?(QueryType.Prop), new SortType?(SortType.Ascending), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>(), Page.templatesProps, new Func<XElement, WikiInfo, templatesSelect>(templatesSelect.Parse));
    private static readonly IDictionary<string, string[]> videoinfoProps = (IDictionary<string, string[]>) new Dictionary<string, string[]>()
    {
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
        new string[7]
        {
          "url",
          "sha1",
          "mime",
          "thumbmime",
          "mediatype",
          "archivename",
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
        "thumbmime",
        new string[1]
        {
          "thumbmime"
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
      },
      {
        "bitdepth",
        new string[1]
        {
          "bitdepth"
        }
      }
    };
    private static readonly QueryTypeProperties<videoinfoSelect> videoinfoProperties = new QueryTypeProperties<videoinfoSelect>("videoinfo", "vi", new QueryType?(QueryType.Prop), new SortType?(), (IEnumerable<Tuple<string, string>>) new TupleList<string, string>(), Page.videoinfoProps, new Func<XElement, WikiInfo, videoinfoSelect>(videoinfoSelect.Parse));

    /// <summary>
    /// Returns information about the given categories
    /// 
    /// </summary>
    public abstract categoryinfoResult categoryinfo { get; }

    /// <summary>
    /// Get basic page information such as namespace, title, last touched date, ...
    /// 
    /// </summary>
    public abstract infoResult info { get; }

    private Page()
    {
    }

    /// <summary>
    /// List all categories the page(s) belong to
    /// 
    /// </summary>
    public abstract WikiQuerySortableGenerator<Page, categoriesWhere, categoriesOrderBy, categoriesSelect> categories();

    /// <summary>
    /// List all files that are duplicates of the given file(s) based on hash values
    /// 
    /// </summary>
    public abstract WikiQuerySortableGenerator<Page, duplicatefilesWhere, duplicatefilesOrderBy, duplicatefilesSelect> duplicatefiles();

    /// <summary>
    /// Returns all external URLs (not interwikis) from the given page(s)
    /// 
    /// </summary>
    public abstract WikiQuery<extlinksWhere, extlinksSelect> extlinks();

    /// <summary>
    /// Returns image information and upload history
    /// 
    /// </summary>
    public abstract WikiQuery<imageinfoWhere, imageinfoSelect> imageinfo();

    /// <summary>
    /// Returns all images contained on the given page(s)
    /// 
    /// </summary>
    public abstract WikiQuerySortableGenerator<Page, imagesWhere, imagesOrderBy, imagesSelect> images();

    /// <summary>
    /// Returns all interwiki links from the given page(s)
    /// 
    /// </summary>
    public abstract WikiQuerySortable<iwlinksWhere, iwlinksOrderBy, iwlinksSelect> iwlinks();

    /// <summary>
    /// Returns all interlanguage links from the given page(s)
    /// 
    /// </summary>
    public abstract WikiQuerySortable<langlinksWhere, langlinksOrderBy, langlinksSelect> langlinks();

    /// <summary>
    /// Returns all links from the given page(s)
    /// 
    /// </summary>
    public abstract WikiQuerySortableGenerator<Page, linksWhere, linksOrderBy, linksSelect> links();

    /// <summary>
    /// Get revision information
    ///             May be used in several ways:
    ///              1) Get data about a set of pages (last revision), by setting titles or pageids parameter
    ///              2) Get revisions for one given page, by using titles/pageids with start/end/limit params
    ///              3) Get data about a set of revisions by setting their IDs with revids parameter
    ///             All parameters marked as (enum) may only be used with a single page (#2)
    /// 
    /// </summary>
    public abstract WikiQuerySortable<revisionsWhere, revisionsOrderBy, revisionsSelect> revisions();

    /// <summary>
    /// Returns all templates from the given page(s)
    /// 
    /// </summary>
    public abstract WikiQuerySortableGenerator<Page, templatesWhere, templatesOrderBy, templatesSelect> templates();

    /// <summary>
    /// Extends imageinfo to include video source information
    /// 
    /// </summary>
    public abstract WikiQuery<videoinfoWhere, videoinfoSelect> videoinfo();
  }
}
