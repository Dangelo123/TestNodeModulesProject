module.exports = function (callback) {
    const _ = require('lodash');
    var result = _.difference([2, 1], [2, 3]).toString();
    callback(null, result);
};