export default  {
   setCredentials(context) {
        context.isLogin = !!localStorage.getItem('userId');
        context.username = localStorage.getItem('username');
        context.userId = localStorage.getItem('userId');
   },
   getDataWithId(d) {
      return {...d.data(), id: d.id};
   }
}