# Diffbot API for .NET

The [Diffbot](http://diffbot.com) API enables users to scrape structured frontpage summaries and full articles from sites. This library is a .NET wrapper around the API.


There are two APIs supported: Frontpage and Article.

## Frontpage

```C#
Diffbot diff = new Diffbot("developer-token-here");
Frontpage frontpage = diff.Frontpage("cnn.com");
```

## Article

```C#
Diffbot diff = new Diffbot("developer-token-here");
Article article = diff.Article("http://url-to.com/article/permalink/here/");
```

## With Proxy

```C#
var proxy = = new WebProxy(@"proxy.somecompany.com", 911);
Diffbot diff = new Diffbot("developer-token-here", proxy);
Article article = diff.Article("http://url-to.com/article/permalink/here/");
```