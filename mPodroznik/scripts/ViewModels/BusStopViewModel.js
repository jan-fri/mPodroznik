function BusStopViewModel(busStop) {
    var self = this;
    
    //self.saveCompleted = ko.observable(false);
   // self.sending = ko.observable(false);

    //if (busStop.ID == 0) {
    //    self.isCreating
    //}
    self.busStops = busStops;
    self.busStop = {
        id: ko.observable(busStop.id),
        busId: ko.observable(busStop.busId),
        busStopName: ko.observable(busStop.busStopName),
        gpsLat: ko.observable(busStop.gpsLat),
        gpsLng: ko.observable(busStop.gpsLng)
    };

    //self.validateAndSave = function (form) {
    //    if (!$(form).valid())
    //        return false;

    //    self.sending(true);

    //    //include ant forgery token
    //  //  self.busStop.__RequestVerificationToken = form[0].value;
    //    $.ajax({
    //        url: 'Edit',
    //        type: 'post',
    //        contentType: 'application/json',
    //        data: ko.toJS(self.busStop)
    //    })
    //    .success(self.successfulSave)
    //    .error(self.errorSave)
    //    .complete(function () { self.sending(false) });

    //self.successfulSave = function () {
    //    self.saveCompleted(true);

    //    $('.body-content').prepend('<div class="alert alert-success"><strong>Success!</strong> Przystaenk autobusowy zostal zmieniony.</div>');
    //    setTimeout(function () {
    //        if (self.isCreating)
    //            location.href = './';
    //        else
    //            location.href = '../';
    //    }, 1000);
    //};

    //self.errorSave = function () {
    //    $('.body-content').prepend('<div class="alert alert-danger"><strong>Error!</strong> Wystapil blad przy zmianie przystanku.</div>');
    
    //};

}



