#!/usr/bin/env node
const argv = require('yargs').argv
 
console.log('build branch: ', argv.branch)
var name = "Test"
var value = "MyValue"
console.log("##teamcity[setParameter name='env." + name + "' value='ParamTestValue']");
console.log("##teamcity[setParameter name='env.DeployFTPHostname' value='ftp://waws-prod-dm1-025.ftp.azurewebsites.windows.net']");
//console.log("##teamcity[buildNumber 'test_value 1']");

console.log("##teamcity[message text='Test -> "+ argv.Test +"' status='NORMAL']");
console.log("##teamcity[message text='MyParam -> "+ argv.MyParam +"' status='NORMAL']");
