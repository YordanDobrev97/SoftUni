function loadRepos() {
    $("#repos").empty();
    let username = $('#username').val();
    let url = `https://api.github.com/users/${username}/repos`;

    $.ajax({
        url,
        success: function loadRepos(repos) {
            for(let repo of repos) {
                let link = $('<a>').text(repo.full_name);
                link.attr('href', repo.html_url);
                let li = $('<li>');
                li.append(link);
                $('#repos').append(li);
            }
        },
        error: () => {
            let li = $('<li>Error</li>');
            $('#repos').append(li);
        }
    });
}