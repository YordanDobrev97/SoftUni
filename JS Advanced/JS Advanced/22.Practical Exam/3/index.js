class Article {
   constructor(title, creator) {
       this.title = title;
       this.creator = creator;
       this._comments = [];
       this._likes = [];
       this._totalLikes = 0;
       this._counter = 1;
   }

   get likes() {
       if (this._totalLikes === 0) {
           return `${this.title} has 0 likes"`; 
       }

       if (this._totalLikes === 1) {
           return `${this._likes[0].username} likes this article!`;
       }
   }

   like (username) {
       if (this._likes.some(x => x.username === username)) {
           throw new Error("You can't like the same article twice!");
       }

       if (this.creator === username) {
           throw new Error("You can't like your own articles!");
       }

       this._likes.push({username: username});
       this._totalLikes++;

       return `${username} liked ${this.title}!`
   }

   dislike(username) {
       if (!this._likes.some(x => x.username === username)) {
            throw new Error("You can't dislike this article!");
       }

       this._totalLikes--;
       return `${username} disliked ${this.title}`
   }

   comment (username, content, id) {
       if (!this._comments.some(x => x.id === id)) {
            this._comments.push({
                id: this._counter,
                username: username,
                content: content
            });

            this._counter++;
            return `${username} commented on ${this.title}`
       } else {
            const currentCommentIndx = this._comments.findIndex(x => x.id === id);
            const currentComment = this._comments[currentCommentIndx];

            currentComment['reply'] = content;
            return `You replied successfully`;
       }
   }

   toString(sortingType) {
       if (sortingType === 'asc') {
           this._comments.sort((a,b) => {
               return a.id - b.id
           });
       } else if (sortingType === 'desc') {
            this._comments.sort((a,b) => {
                return b.id - a.id
            });
       } else {
            this._comments.sort((a,b) => {
                return a.username.localCompare(b.username);
            });
       }

       let output = `Title: ${this.title}\n`;
       output += `Creator: ${this.creator}\n`;
       output += `Likes: ${this._totalLikes}\n`;
       output += `Comments:\n`;

       for(let item of this._comments) {
           //-- {id}. {username}: {content}
           output += `-- ${item.id}. ${item.username}: ${item.content}\n`;
       }
   }
}

let art = new Article("My Article", "Anny");
art.like("John");
console.log(art.likes);
art.dislike("John");
console.log(art.likes);
art.comment("Sammy", "Some Content");
console.log(art.comment("Ammy", "New Content"));
art.comment("Zane", "Reply", 1);
art.comment("Jessy", "Nice :)");
console.log(art.comment("SAmmy", "Reply@", 1));
console.log()
console.log(art.toString('username'));
console.log()
art.like("Zane");
console.log(art.toString('desc'));

