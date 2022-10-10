Olá, bom dia, ai vai o codigo completo... Boa sorte!

<html>
<head>
<title>Default</title>
</head>
<body>
<div style="width:350px;height:350px;border:dashed 1px #ccc;" id="view_photo"><img id='output' style="height:100px; width:100px"></div>
<input type="file" name="files" />

<!--[Script]-->
<script>
var files = document.querySelector('input[name="files"]');

files.addEventListener("change", function(file){
	var input = file.target;
	
	var reader = new FileReader();
    
	reader.onload = function(){
      var dataURL = reader.result;
      var output = document.getElementById('output');
      output.src = dataURL;
    };

    reader.readAsDataURL(input.files[0]);
});
</script>
</body>
</html>