// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.logeventsaction
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class logeventsaction : StringValue
  {
    public static readonly logeventsaction block_block = new logeventsaction("block/block");
    public static readonly logeventsaction block_unblock = new logeventsaction("block/unblock");
    public static readonly logeventsaction block_reblock = new logeventsaction("block/reblock");
    public static readonly logeventsaction protect_protect = new logeventsaction("protect/protect");
    public static readonly logeventsaction protect_modify = new logeventsaction("protect/modify");
    public static readonly logeventsaction protect_unprotect = new logeventsaction("protect/unprotect");
    public static readonly logeventsaction protect_move_prot = new logeventsaction("protect/move_prot");
    public static readonly logeventsaction upload_upload = new logeventsaction("upload/upload");
    public static readonly logeventsaction upload_overwrite = new logeventsaction("upload/overwrite");
    public static readonly logeventsaction upload_revert = new logeventsaction("upload/revert");
    public static readonly logeventsaction import_upload = new logeventsaction("import/upload");
    public static readonly logeventsaction import_interwiki = new logeventsaction("import/interwiki");
    public static readonly logeventsaction merge_merge = new logeventsaction("merge/merge");
    public static readonly logeventsaction suppress_block = new logeventsaction("suppress/block");
    public static readonly logeventsaction suppress_reblock = new logeventsaction("suppress/reblock");
    public static readonly logeventsaction review_approve = new logeventsaction("review/approve");
    public static readonly logeventsaction review_approve2 = new logeventsaction("review/approve2");
    public static readonly logeventsaction review_approve_i = new logeventsaction("review/approve-i");
    public static readonly logeventsaction review_approve2_i = new logeventsaction("review/approve2-i");
    public static readonly logeventsaction review_approve_a = new logeventsaction("review/approve-a");
    public static readonly logeventsaction review_approve2_a = new logeventsaction("review/approve2-a");
    public static readonly logeventsaction review_approve_ia = new logeventsaction("review/approve-ia");
    public static readonly logeventsaction review_approve2_ia = new logeventsaction("review/approve2-ia");
    public static readonly logeventsaction review_unapprove = new logeventsaction("review/unapprove");
    public static readonly logeventsaction review_unapprove2 = new logeventsaction("review/unapprove2");
    public static readonly logeventsaction rights_erevoke = new logeventsaction("rights/erevoke");
    public static readonly logeventsaction gblblock_gblock = new logeventsaction("gblblock/gblock");
    public static readonly logeventsaction gblblock_gblock2 = new logeventsaction("gblblock/gblock2");
    public static readonly logeventsaction gblblock_gunblock = new logeventsaction("gblblock/gunblock");
    public static readonly logeventsaction gblblock_whitelist = new logeventsaction("gblblock/whitelist");
    public static readonly logeventsaction gblblock_dwhitelist = new logeventsaction("gblblock/dwhitelist");
    public static readonly logeventsaction gblblock_modify = new logeventsaction("gblblock/modify");
    public static readonly logeventsaction globalauth_delete = new logeventsaction("globalauth/delete");
    public static readonly logeventsaction globalauth_lock = new logeventsaction("globalauth/lock");
    public static readonly logeventsaction globalauth_unlock = new logeventsaction("globalauth/unlock");
    public static readonly logeventsaction globalauth_hide = new logeventsaction("globalauth/hide");
    public static readonly logeventsaction globalauth_unhide = new logeventsaction("globalauth/unhide");
    public static readonly logeventsaction globalauth_lockandhid = new logeventsaction("globalauth/lockandhid");
    public static readonly logeventsaction globalauth_setstatus = new logeventsaction("globalauth/setstatus");
    public static readonly logeventsaction suppress_setstatus = new logeventsaction("suppress/setstatus");
    public static readonly logeventsaction gblrights_usergroups = new logeventsaction("gblrights/usergroups");
    public static readonly logeventsaction gblrights_groupperms = new logeventsaction("gblrights/groupperms");
    public static readonly logeventsaction gblrights_groupprms2 = new logeventsaction("gblrights/groupprms2");
    public static readonly logeventsaction gblrights_groupprms3 = new logeventsaction("gblrights/groupprms3");
    public static readonly logeventsaction suppress_hide_afl = new logeventsaction("suppress/hide-afl");
    public static readonly logeventsaction suppress_unhide_afl = new logeventsaction("suppress/unhide-afl");
    public static readonly logeventsaction move_move = new logeventsaction("move/move");
    public static readonly logeventsaction move_move_redir = new logeventsaction("move/move_redir");
    public static readonly logeventsaction delete_delete = new logeventsaction("delete/delete");
    public static readonly logeventsaction delete_restore = new logeventsaction("delete/restore");
    public static readonly logeventsaction delete_revision = new logeventsaction("delete/revision");
    public static readonly logeventsaction delete_event = new logeventsaction("delete/event");
    public static readonly logeventsaction suppress_revision = new logeventsaction("suppress/revision");
    public static readonly logeventsaction suppress_event = new logeventsaction("suppress/event");
    public static readonly logeventsaction suppress_delete = new logeventsaction("suppress/delete");
    public static readonly logeventsaction patrol_patrol = new logeventsaction("patrol/patrol");
    public static readonly logeventsaction rights_rights = new logeventsaction("rights/rights");
    public static readonly logeventsaction rights_autopromote = new logeventsaction("rights/autopromote");
    public static readonly logeventsaction stable_config = new logeventsaction("stable/config");
    public static readonly logeventsaction stable_modify = new logeventsaction("stable/modify");
    public static readonly logeventsaction stable_reset = new logeventsaction("stable/reset");
    public static readonly logeventsaction spamblacklist_star = new logeventsaction("spamblacklist/*");
    public static readonly logeventsaction renameuser_renameuser = new logeventsaction("renameuser/renameuser");
    public static readonly logeventsaction gblrights_grouprename = new logeventsaction("gblrights/grouprename");
    public static readonly logeventsaction gblrights_newset = new logeventsaction("gblrights/newset");
    public static readonly logeventsaction gblrights_setrename = new logeventsaction("gblrights/setrename");
    public static readonly logeventsaction gblrights_setnewtype = new logeventsaction("gblrights/setnewtype");
    public static readonly logeventsaction gblrights_setchange = new logeventsaction("gblrights/setchange");
    public static readonly logeventsaction gblrights_deleteset = new logeventsaction("gblrights/deleteset");
    public static readonly logeventsaction abusefilter_modify = new logeventsaction("abusefilter/modify");
    public static readonly logeventsaction abusefilter_hit = new logeventsaction("abusefilter/hit");
    public static readonly logeventsaction articlefeedbackv5_protect = new logeventsaction("articlefeedbackv5/protect");
    public static readonly logeventsaction articlefeedbackv5_create = new logeventsaction("articlefeedbackv5/create");
    public static readonly logeventsaction articlefeedbackv5_helpful = new logeventsaction("articlefeedbackv5/helpful");
    public static readonly logeventsaction articlefeedbackv5_undo_helpful = new logeventsaction("articlefeedbackv5/undo-helpful");
    public static readonly logeventsaction articlefeedbackv5_unhelpful = new logeventsaction("articlefeedbackv5/unhelpful");
    public static readonly logeventsaction articlefeedbackv5_undo_unhelpful = new logeventsaction("articlefeedbackv5/undo-unhelpful");
    public static readonly logeventsaction articlefeedbackv5_flag = new logeventsaction("articlefeedbackv5/flag");
    public static readonly logeventsaction articlefeedbackv5_unflag = new logeventsaction("articlefeedbackv5/unflag");
    public static readonly logeventsaction articlefeedbackv5_autoflag = new logeventsaction("articlefeedbackv5/autoflag");
    public static readonly logeventsaction articlefeedbackv5_clear_flags = new logeventsaction("articlefeedbackv5/clear-flags");
    public static readonly logeventsaction articlefeedbackv5_feature = new logeventsaction("articlefeedbackv5/feature");
    public static readonly logeventsaction articlefeedbackv5_unfeature = new logeventsaction("articlefeedbackv5/unfeature");
    public static readonly logeventsaction articlefeedbackv5_resolve = new logeventsaction("articlefeedbackv5/resolve");
    public static readonly logeventsaction articlefeedbackv5_unresolve = new logeventsaction("articlefeedbackv5/unresolve");
    public static readonly logeventsaction articlefeedbackv5_noaction = new logeventsaction("articlefeedbackv5/noaction");
    public static readonly logeventsaction articlefeedbackv5_unnoaction = new logeventsaction("articlefeedbackv5/unnoaction");
    public static readonly logeventsaction articlefeedbackv5_inappropriate = new logeventsaction("articlefeedbackv5/inappropriate");
    public static readonly logeventsaction articlefeedbackv5_uninappropriate = new logeventsaction("articlefeedbackv5/uninappropriate");
    public static readonly logeventsaction articlefeedbackv5_archive = new logeventsaction("articlefeedbackv5/archive");
    public static readonly logeventsaction articlefeedbackv5_unarchive = new logeventsaction("articlefeedbackv5/unarchive");
    public static readonly logeventsaction articlefeedbackv5_hide = new logeventsaction("articlefeedbackv5/hide");
    public static readonly logeventsaction articlefeedbackv5_unhide = new logeventsaction("articlefeedbackv5/unhide");
    public static readonly logeventsaction articlefeedbackv5_autohide = new logeventsaction("articlefeedbackv5/autohide");
    public static readonly logeventsaction suppress_request = new logeventsaction("suppress/request");
    public static readonly logeventsaction suppress_unrequest = new logeventsaction("suppress/unrequest");
    public static readonly logeventsaction suppress_decline = new logeventsaction("suppress/decline");
    public static readonly logeventsaction suppress_oversight = new logeventsaction("suppress/oversight");
    public static readonly logeventsaction suppress_unoversight = new logeventsaction("suppress/unoversight");
    public static readonly logeventsaction pagetriage_curation_reviewed = new logeventsaction("pagetriage-curation/reviewed");
    public static readonly logeventsaction pagetriage_curation_unreviewed = new logeventsaction("pagetriage-curation/unreviewed");
    public static readonly logeventsaction pagetriage_curation_tag = new logeventsaction("pagetriage-curation/tag");
    public static readonly logeventsaction pagetriage_curation_delete = new logeventsaction("pagetriage-curation/delete");
    public static readonly logeventsaction pagetriage_deletion_delete = new logeventsaction("pagetriage-deletion/delete");
    public static readonly logeventsaction institution_star = new logeventsaction("institution/*");
    public static readonly logeventsaction course_star = new logeventsaction("course/*");
    public static readonly logeventsaction student_star = new logeventsaction("student/*");
    public static readonly logeventsaction student_add = new logeventsaction("student/add");
    public static readonly logeventsaction student_remove = new logeventsaction("student/remove");
    public static readonly logeventsaction online_star = new logeventsaction("online/*");
    public static readonly logeventsaction online_add = new logeventsaction("online/add");
    public static readonly logeventsaction online_remove = new logeventsaction("online/remove");
    public static readonly logeventsaction campus_star = new logeventsaction("campus/*");
    public static readonly logeventsaction campus_add = new logeventsaction("campus/add");
    public static readonly logeventsaction campus_remove = new logeventsaction("campus/remove");
    public static readonly logeventsaction instructor_star = new logeventsaction("instructor/*");
    public static readonly logeventsaction instructor_add = new logeventsaction("instructor/add");
    public static readonly logeventsaction instructor_remove = new logeventsaction("instructor/remove");
    public static readonly logeventsaction eparticle_star = new logeventsaction("eparticle/*");
    public static readonly logeventsaction thanks_star = new logeventsaction("thanks/*");
    public static readonly logeventsaction newusers_newusers = new logeventsaction("newusers/newusers");
    public static readonly logeventsaction newusers_create = new logeventsaction("newusers/create");
    public static readonly logeventsaction newusers_create2 = new logeventsaction("newusers/create2");
    public static readonly logeventsaction newusers_byemail = new logeventsaction("newusers/byemail");
    public static readonly logeventsaction newusers_autocreate = new logeventsaction("newusers/autocreate");

    internal logeventsaction(string value)
      : base(value)
    {
    }

    public static bool operator ==(logeventsaction first, logeventsaction second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(logeventsaction first, logeventsaction second)
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
