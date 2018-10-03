#!/usr/bin/env node
const argv = require('yargs').argv
 
console.log('build branch: ', argv.branch)

Write-Host "##teamcity[setParameter name='env.Test' value='test_value 1']";
console.log("##teamcity[message text='Test -> "+ argv.Test +"' status='NORMAL']");
