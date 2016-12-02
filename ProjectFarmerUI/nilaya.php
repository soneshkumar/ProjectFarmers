

<?php
include('header.php');

?>

<body>
<div class="iframe">
<iframe
         src="//walkinto.in/tour/-yoZSb8YdZ-kli-rWItub"
         width="100%"
         height="600"
         allowfullscreen="true"
         webkitallowfullscreen="true"
         mozallowfullscreen="true"
         oallowfullscreen="true"
         msallowfullscreen="true"
         frameborder="0"
         scrolling="no"
         marginheight="0"
         marginwidth="0">
</iframe>
</div>


<div class="modal fade" id="query-modal">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title">Request A Query</h4>
      </div>
      <div class="modal-body">
        <div class="form-group">
            <input class="form-control" placeholder="Name" name="qname" id="qname" type="text" autofocus />
        </div>
        <div class="form-group">
            <input class="form-control" placeholder="Email Id" name="qemail" id="qemail" type="text" />
        </div>
      <div class="form-group">
            <input class="form-control" placeholder="Phone no" name="qphone" id="qphone" type="text" />
        </div>
        <div class="form-group">
            <input class="form-control" placeholder="Select a date" name="qdate" id="qdate" type="text" />
        </div>
      <div class="form-group">
            <input class="form-control" placeholder="Message" name="qmessage" id="qmessage" type="text" />
        </div>
          <div class="form-group">
            <p id="qerror" style="color:#f00;"></p>
          </div>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
        <button type="button" id="btn-query" class="btn btn-primary">Submit</button>
      </div>
    </div><!-- /.modal-content -->
  </div><!-- /.modal-dialog -->
</div><!-- /.modal -->

</body>