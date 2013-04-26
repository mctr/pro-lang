<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<title>Login - show</title>
<link href="http://twitter.github.com/bootstrap/assets/css/bootstrap.css" rel="stylesheet">

<style type="text/css">
body {
	padding-top: 60px;
	padding-bottom: 40px;
	background-color: #f5f5f5;
}

.form-signin {
	max-width: 300px;
	padding: 19px 29px 29px;
	margin: 0 auto 20px;
	background-color: #fff;
	border: 1px solid #e5e5e5;
	-webkit-border-radius: 5px;
	-moz-border-radius: 5px;
	border-radius: 5px;
	-webkit-box-shadow: 0 1px 2px rgba(0, 0, 0, .05);
	-moz-box-shadow: 0 1px 2px rgba(0, 0, 0, .05);
	box-shadow: 0 1px 2px rgba(0, 0, 0, .05);
}

.form-signin input[type="text"],.form-signin input[type="password"] {
	font-size: 16px;
	height: auto;
	margin-bottom: 15px;
	padding: 7px 9px;
}

.form-signin-heading {
	text-align: center;
	margin-bottom: 30px;
}
</style>
</head>
<body>
  <div class="container">

    <form action="/First_jsp/welcome.jsp" accept-charset="utf-8" class="form-signin form-horizontal">
      <h3 class="form-signin-heading">Login...</h3>
      <h4>Kullanici Adi :</h4>
      <input type="text" class="input-block-level" name="user_name">
      <h4>Parola :</h4>
      <input type="password" class="input-block-level" name="password">
      <button class="btn btn-large btn-primary" type="submit">Giris</button>
      </form>
     
     
    </div>

  </body>
</html>