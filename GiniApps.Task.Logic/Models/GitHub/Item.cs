using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiniApps.Task.Logic.Models.GitHub
{
    internal class Item
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("node_id")]
        public string NodeID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("@private")]
        public bool Private { get; set; }

        [JsonProperty("owner")]
        public Owner Owner { get; set; }

        [JsonProperty("html_url")]
        public string HtmlURL { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fork")]
        public bool Fork { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("forks_url")]
        public string ForksURL { get; set; }

        [JsonProperty("keys_url")]
        public string KeysURL { get; set; }

        [JsonProperty("collaborators_url")]
        public string CollaboratorsURL { get; set; }

        [JsonProperty("teams_url")]
        public string TeamsURL { get; set; }

        [JsonProperty("hooks_url")]
        public string HooksURL { get; set; }

        [JsonProperty("issue_events_url")]
        public string IssueEventsURL { get; set; }

        [JsonProperty("events_url")]
        public string EventsURL { get; set; }

        [JsonProperty("assignees_url")]
        public string AssigneesURL { get; set; }

        [JsonProperty("branches_url")]
        public string BranchesURL { get; set; }

        [JsonProperty("tags_url")]
        public string TagsURL { get; set; }

        [JsonProperty("blobs_url")]
        public string BlobsURL { get; set; }

        [JsonProperty("git_tags_url")]
        public string GitTagsURL { get; set; }

        [JsonProperty("git_refs_url")]
        public string GitRefsURL { get; set; }

        [JsonProperty("trees_url")]
        public string TreesURL { get; set; }

        [JsonProperty("statuses_url")]
        public string StatusesURL { get; set; }

        [JsonProperty("languages_url")]
        public string LanguagesURL { get; set; }

        [JsonProperty("stargazers_url")]
        public string StargazersURL { get; set; }

        [JsonProperty("contributors_url")]
        public string ContributorsURL { get; set; }

        [JsonProperty("subscribers_url")]
        public string SubscribersURL { get; set; }

        [JsonProperty("subscription_url")]
        public string SubscriptionURL { get; set; }

        [JsonProperty("commits_url")]
        public string CommitsURL { get; set; }

        [JsonProperty("git_commits_url")]
        public string GitCommitsURL { get; set; }

        [JsonProperty("comments_url")]
        public string CommentsURL { get; set; }

        [JsonProperty("issue_comment_url")]
        public string IssueCommentURL { get; set; }

        [JsonProperty("contents_url")]
        public string ContentsURL { get; set; }

        [JsonProperty("compare_url")]
        public string CompareURL { get; set; }

        [JsonProperty("merges_url")]
        public string MergesURL { get; set; }

        [JsonProperty("archive_url")]
        public string ArchiveURL { get; set; }

        [JsonProperty("downloads_url")]
        public string DownloadsURL { get; set; }

        [JsonProperty("issues_url")]
        public string IssuesURL { get; set; }

        [JsonProperty("pulls_url")]
        public string PullsURL { get; set; }

        [JsonProperty("milestones_url")]
        public string MilestonesURL { get; set; }

        [JsonProperty("notifications_url")]
        public string NotificationsURL { get; set; }

        [JsonProperty("labels_url")]
        public string LabelsURL { get; set; }

        [JsonProperty("releases_url")]
        public string ReleasesURL { get; set; }

        [JsonProperty("deployments_url")]
        public string DeploymentsURL { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("pushed_at")]
        public DateTime PushedAt { get; set; }

        [JsonProperty("git_url")]
        public string GitURL { get; set; }

        [JsonProperty("ssh_url")]
        public string SshURL { get; set; }

        [JsonProperty("clone_url")]
        public string CloneURL { get; set; }

        [JsonProperty("svn_url")]
        public string SvnURL { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("stargazers_count")]
        public int StargazersCount { get; set; }

        [JsonProperty("watchers_count")]
        public int WatchersCount { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("has_issues")]
        public bool HasIssues { get; set; }

        [JsonProperty("has_projects")]
        public bool HasProjects { get; set; }

        [JsonProperty("has_downloads")]
        public bool HasDownloads { get; set; }

        [JsonProperty("has_wiki")]
        public bool HasWiki { get; set; }

        [JsonProperty("has_pages")]
        public bool HasPages { get; set; }

        [JsonProperty("has_discussions")]
        public bool HasDiscussions { get; set; }

        [JsonProperty("forks_count")]
        public int ForksCount { get; set; }

        [JsonProperty("mirror_url")]
        public object MirrorURL { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("open_issues_count")]
        public int OpenIssuesCount { get; set; }

        [JsonProperty("license")]
        public License License { get; set; }

        [JsonProperty("allow_forking")]
        public bool AllowForking { get; set; }

        [JsonProperty("is_template")]
        public bool IsTemplate { get; set; }

        [JsonProperty("web_commit_signoff_required")]
        public bool WebCommitSignoffRequired { get; set; }

        [JsonProperty("topics")]
        public List<string> Topics { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("forks")]
        public int Forks { get; set; }

        [JsonProperty("open_issues")]
        public int OpenIssues { get; set; }

        [JsonProperty("watchers")]
        public int Watchers { get; set; }

        [JsonProperty("default_branch")]
        public string DefaultBranch { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

    }
}
