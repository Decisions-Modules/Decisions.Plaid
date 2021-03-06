function PlaidLinkFlowControl() {}

PlaidLinkFlowControl.prototype.initialize = function (host, component) {
  this.host = host; // Keep track of the host; we'll need it later.
  this.linkToken = "default-link-token";
  this.publicToken = "";

  this.lastConsumed = null;

  let myScript = document.createElement("script");
  myScript.setAttribute(
    "src",
    "https://cdn.plaid.com/link/v2/stable/link-initialize.js"
  );
  host[0].appendChild(myScript);
};

PlaidLinkFlowControl.prototype.resize = function (height, width) {
  if (this.host && height && width && height > 0 && width > 0) {
    this.host.css({ width: width, height: height });
  }
};

PlaidLinkFlowControl.prototype.setValue = function (data) {
  setTimeout(() => {
  if (data && JSON.stringify(data) !== JSON.stringify(this.lastConsumed)) {
    this.lastConsumed = data;
    this.linkToken = data.LinkToken;

    const handler = Plaid.create({
      token: data.LinkToken,
      onSuccess: (public_token, metadata) => {
        this.publicToken = public_token;
      },
      onLoad: () => {},
      onExit: (err, metadata) => {},
      onEvent: (eventName, metadata) => {},
      receivedRedirectUri: null
    });

    
    var button = document.createElement('button');
    button.type = 'button';
    button.textContent = 'Click me';
    button.onclick = function(e){
      handler.open();
    }
    this.host[0].appendChild(button);
  }
  }, 500);
};

PlaidLinkFlowControl.prototype.getValue = function () {
  return {
    PublicToken: this.publicToken
  };
};
