function getArticleGenerator(articles) {
    const content = document.getElementById('content');
    let currentArticle = 0;

    return function() {
        if (currentArticle < articles.length) {
            const article = document.createElement('article');
            article.textContent =articles[currentArticle]; 
            content.appendChild(article);
            currentArticle++;
        }
    }
}
