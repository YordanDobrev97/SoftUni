const forum = (function(){
    let commands = {
        upvote: (post) => {
            post.upvotes += 1;
        },
        downvote: (post) => {
            post.downvotes += 1;
        },
        score: (post) => {
            let upvotes = post.upvotes;
            let downvotes = post.downvotes;
            let obfuscationNumber = 0;
            let votes;
            if ((upvotes + downvotes) > 50)  {
                votes = Math.max(upvotes, downvotes);
                obfuscationNumber = Math.ceil(0.25 * votes);
            }
            let raiting = (upvotes, downvotes) => {
                let totalVotes = upvotes + downvotes;
                let differentVotes =upvotes - downvotes;

                if (totalVotes < 10) {
                    return 'new';
                }

                if ((upvotes / totalVotes) > 0.66) {
                    return 'hot';
                }

                if ((downvotes / totalVotes <= 0.66) && differentVotes >= 0 && (upvotes > 100 || downvotes > 100)) {
                    return 'controversial';
                }

                if (differentVotes < 0 && totalVotes >= 10) {
                    return 'unpopular';
                }
                return 'new';
            }
            let resultRaiting = raiting(upvotes, downvotes);
            return [upvotes + obfuscationNumber, downvotes + obfuscationNumber, upvotes - downvotes, resultRaiting];
        }
    }

    return {
        call: (post, action) => {
            return commands[action](post);
        }
    }
});

let post = {
    id: '3',
    author: 'emil',
    content: 'wazaaaaa',
    upvotes: 100,
    downvotes: 100
};

const solution = forum();
solution.call(post, 'upvote');
solution.call(post, 'downvote');
let score = solution.call(post, 'score');
console.log(score);

solution.call(post, 'downvote');
score = solution.call(post, 'score');
console.log(score);
