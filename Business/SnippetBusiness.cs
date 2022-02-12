namespace Seo;

public class SnippetBusiness : Business<Snippet, Snippet>
{
    protected override Read<Snippet> Read => Repository.Snippet;

    protected override Write<Snippet> Write => Repository.Snippet;

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