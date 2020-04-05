export default  {
   setCredentials(context) {
        context.isLogin = !!sessionStorage.getItem('userId');
   },
   getDataWithId(d) {
      return {...d.data(), id: d.id};
   }
}