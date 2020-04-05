export default  {
   setCredentials(context) {
        context.isLogin = !!sessionStorage.getItem('userId');
        context.names = sessionStorage.getItem('fullname');
   },
   getDataWithId(d) {
      return {...d.data(), id: d.id};
   }
}