namespace GitHubReposSearch
{
    using System.Collections.Generic;

    public class RepoSearchResponseModel
    {
        public int Total_Count { get; set; }

        public List<Repo> Items { get; set; }
    }
}
