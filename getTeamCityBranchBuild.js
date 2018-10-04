#!/usr/bin/env node
const argv = require('yargs').argv
 
console.log('build branch: ', argv.branch)
var name = "Test"
var value = "MyValue"
console.log("##teamcity[env.Test MyValue]");
console.log("##teamcity[buildNumber 'test_value 1']");
console.log("##teamcity[message text='Test -> "+ argv.Test +"' status='NORMAL']");
