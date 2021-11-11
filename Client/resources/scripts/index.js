function getPosts()
{
    const allPostsApiUrl = "https://localhost:7116/api/posts";

    fetch(allPostsApiUrl).then(function(response){
        console.log(response);
        return response.json();
    }).then(function(json){
        let html = "<ul>";
        json.forEach(post)=>{
            html+= "<li>" + post.id + post.Text + post.Date + "</li>";
        }
    })
}