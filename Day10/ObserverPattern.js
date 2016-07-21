(function ()
{
    function Provider()
    {
        this.users = [];
    }
    function User(name)
    {
        if (name) {
            this.name = name;
        }
    };
    User.prototype.getMessages = function (prov)
    {
        alert('Dear friend ' + this.name + '! ' + prov + ' wishes you a good day!');
    }
    User.prototype.connect = function (provider)
    {
        provider.users.push(this);
    };
    Provider.prototype.toSendNews = function (data)
    {
        for (var item in this.users)
        {
            this.users[item].getMessages(data);
        }
    };
    var FlyNet = new Provider;
    var AtlantTelecom = new Provider;
    var CosmosTV = new Provider;
    var MTS = new Provider;

    var VadzimHuryn = new User("VadzimHuryn");
    var AnastasiyaKodyna = new User("AnastasiyaKodyna");
    var IgorShketov = new User("IgorShketov");
    var KiryllSmolovskiy = new User("KiryllSmolovskiy");
    var EkaterinaSavasteeva = new User("EkaterinaSavasteeva");
    var ArtsiomValmus = new User("ArtsiomValmus");

    VadzimHuryn.connect(FlyNet);
    IgorShketov.connect(MTS);
    AnastasiyaKodyna.connect(MTS);
    ArtsiomValmus.connect(MTS);
    EkaterinaSavasteeva.connect(CosmosTV);
    KiryllSmolovskiy.connect(AtlantTelecom);

    alert(FlyNet.toSendNews("FlyNet Copmany"));
    alert(AtlantTelecom.toSendNews("AtlantTelecom Copmany"));
    alert(MTS.toSendNews("MTS Copmany"));
    alert(CosmosTV.toSendNews("CosmosTV Copmany"));

})();
