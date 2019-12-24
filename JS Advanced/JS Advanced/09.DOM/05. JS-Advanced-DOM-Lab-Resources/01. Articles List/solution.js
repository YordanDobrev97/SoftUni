function createArticle() {
	let title = document.getElementById('createTitle').value;
	let content = document.getElementById('createContent').value;

	if (title != '' && content != '') {
		let articles = document.getElementById('articles');
		let article = document.createElement('article');
		let h3 = document.createElement('h3');
		h3.textContent = title;
		let p = document.createElement('p');
		p.textContent = content;

		article.appendChild(h3);
		article.appendChild(p);

		articles.appendChild(article);

		document.getElementById('createTitle').value = '';
		document.getElementById('createContent').value = '';
	}
}