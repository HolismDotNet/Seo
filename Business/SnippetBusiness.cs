namespace Seo;

public class SnippetBusiness : Business<Snippet, Snippet>
{
    protected override ReadRepository<Snippet> ReadRepository => Repository.Snippet;

    protected override Repository<Snippet> WriteRepository => Repository.Snippet;

    /*
    definitions
    instances
        entity type
        entity
        query parameters
    dynamic forms
    link to https://search.google.com/test/rich-results
    */
}