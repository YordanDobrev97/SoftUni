export default  {
   setCredentials(context) {
        context.isLogin = !!sessionStorage.getItem('userId');
        context.username = sessionStorage.getItem('username');
   },
   getDataWithId(d) {
      return {...d.data(), id: d.id};
   }
}