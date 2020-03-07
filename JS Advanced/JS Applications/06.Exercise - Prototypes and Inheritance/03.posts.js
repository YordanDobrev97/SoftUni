function posts() {
    class Post {
        constructor(title, content) {
            this.title = title;
            this.content = content;
        }

        toString() {
            let result = `Post: ${this.title}\n`;
            result += `Content: ${this.content}`;
            return result;
        }
    }

    class SocialMediaPost extends Post {
        constructor(title, content, likes, dislikes) {
            super(title, content);
            this.likes = likes;
            this.dislikes = dislikes;
            this.comments = [];
        }

        addComment(comment) {
            this.comments.push(comment);
        }

        toString() {
            let baseToString = super.toString() + '\n';
            baseToString += `Rating: ${this.likes - this.dislikes}`;

            if (this.comments.length) {
                baseToString += '\n';
                baseToString += `Comments:\n`;
                this.comments.forEach(comment => {
                    baseToString += ` * ${comment}\n`;
                });
            }
            return baseToString.trim();            
        }
    }

    class BlogPost extends Post {
        constructor(title, content, view) {
            super(title, content);
            this._view = view;
        }

        view() {
            this._view++;
            return this;
        }

        toString() {
            let baseToString = super.toString() + '\n';
            baseToString += `Views: ${this._view}`;
            return baseToString;
        }
    }

    return {
        Post,
        SocialMediaPost,
        BlogPost
    }
}

const Post = posts().Post;
let post = new Post("Post", "Content");

console.log(post.toString());

// Post: Post
// Content: Content

const SocialMediaPost = posts().SocialMediaPost;
let scm = new SocialMediaPost("TestTitle", "TestContent", 25, 30);

scm.addComment("Good post");
scm.addComment("Very good post");
scm.addComment("Wow!");

console.log(scm.toString());

const BlogPost = posts().BlogPost;
const blog = new BlogPost('TestTitle', 'TestContent', 5);

blog.view().view().view();

console.log(blog.toString());