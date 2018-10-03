#!/usr/bin/env node
const argv = require('yargs').argv
 
console.log('build branch: ', argv.branch)

console.log("##teamcity[setParameter name='Test' value='test_value 1']");
console.log("##teamcity[message text='Test -> "+ argv.Test +"' status='NORMAL']");
