# TelephonySessionNotifications

So this project is for quick testing of RingCentral telephony session notifications.


## Sample output

```
{"uuid":"5401376064630140920","event":"/restapi/v1.0/account/233676004/telephony/sessions","timestamp":"2020-02-21T22:06:24.490Z","subscriptionId":"930bf156-f529-4860-8acd-c098ba99e965","ownerId":"233676004","body":{"sequence":2,"sessionId":"22042985004","telephonySessionId":"s-064b8e4aee274bdd98f021ddcaf8a50f","serverId":"10.28.20.109.TAM","eventTime":"2020-02-21T22:06:24.384Z","parties":[{"accountId":"233676004","id":"p-064b8e4aee274bdd98f021ddcaf8a50f-1","direction":"Outbound","to":{"phoneNumber":"+15178795131"},"from":{"phoneNumber":"+16504306662"},"status":{"code":"Setup","rcc":false},"missedCall":false,"standAlone":false,"muted":false}],"origin":{"type":"Call"}}}
{"uuid":"3416195700883367101","event":"/restapi/v1.0/account/233676004/telephony/sessions","timestamp":"2020-02-21T22:06:24.499Z","subscriptionId":"930bf156-f529-4860-8acd-c098ba99e965","ownerId":"233676004","body":{"sequence":3,"sessionId":"22042985004","telephonySessionId":"s-064b8e4aee274bdd98f021ddcaf8a50f","serverId":"10.28.20.109.TAM","eventTime":"2020-02-21T22:06:24.411Z","parties":[{"accountId":"233676004","id":"p-064b8e4aee274bdd98f021ddcaf8a50f-2","direction":"Inbound","to":{"phoneNumber":"+15178795131","name":"Tyler Long","extensionId":"233676004"},"from":{"phoneNumber":"+16504306662"},"status":{"code":"Setup","rcc":false},"missedCall":false,"standAlone":false,"muted":false}],"origin":{"type":"Call"}}}
{"uuid":"4899824203112614492","event":"/restapi/v1.0/account/233676004/telephony/sessions","timestamp":"2020-02-21T22:06:24.667Z","subscriptionId":"930bf156-f529-4860-8acd-c098ba99e965","ownerId":"233676004","body":{"sequence":4,"sessionId":"22042985004","telephonySessionId":"s-064b8e4aee274bdd98f021ddcaf8a50f","serverId":"10.28.20.109.TAM","eventTime":"2020-02-21T22:06:24.538Z","parties":[{"accountId":"233676004","id":"p-064b8e4aee274bdd98f021ddcaf8a50f-1","direction":"Outbound","to":{"phoneNumber":"+15178795131","name":"Tyler Long","extensionId":"233676004"},"from":{"phoneNumber":"+16504306662"},"status":{"code":"Answered","rcc":false},"missedCall":false,"standAlone":false,"muted":false}],"origin":{"type":"Call"}}}
{"uuid":"3432969770056497447","event":"/restapi/v1.0/account/233676004/telephony/sessions","timestamp":"2020-02-21T22:06:33.601Z","subscriptionId":"930bf156-f529-4860-8acd-c098ba99e965","ownerId":"233676004","body":{"sequence":5,"sessionId":"22042985004","telephonySessionId":"s-064b8e4aee274bdd98f021ddcaf8a50f","serverId":"10.28.20.109.TAM","eventTime":"2020-02-21T22:06:33.449Z","parties":[{"accountId":"233676004","id":"p-064b8e4aee274bdd98f021ddcaf8a50f-2","direction":"Inbound","to":{"phoneNumber":"+15178795131","name":"Tyler Long","extensionId":"233676004"},"from":{"phoneNumber":"+16504306662"},"status":{"code":"Disconnected","reason":"CallerInputRedirect","rcc":false},"missedCall":false,"standAlone":false,"muted":false}],"origin":{"type":"Call"}}}
{"uuid":"8067264761927691","event":"/restapi/v1.0/account/233676004/extension/233676004/telephony/sessions","timestamp":"2020-02-21T22:06:33.627Z","subscriptionId":"930bf156-f529-4860-8acd-c098ba99e965","ownerId":"233676004","body":{"sequence":6,"sessionId":"22042985004","telephonySessionId":"s-064b8e4aee274bdd98f021ddcaf8a50f","serverId":"10.28.20.109.TAM","eventTime":"2020-02-21T22:06:33.449Z","parties":[{"accountId":"233676004","extensionId":"233676004","id":"p-064b8e4aee274bdd98f021ddcaf8a50f-3","direction":"Inbound","to":{"phoneNumber":"101","name":"Tyler Long","extensionId":"233676004"},"from":{"phoneNumber":"+16504306662"},"status":{"code":"Setup","rcc":false},"missedCall":false,"standAlone":false,"muted":false}],"origin":{"type":"Call"}}}
{"uuid":"3683922534307023847","event":"/restapi/v1.0/account/233676004/extension/233676004/telephony/sessions","timestamp":"2020-02-21T22:06:33.675Z","subscriptionId":"930bf156-f529-4860-8acd-c098ba99e965","ownerId":"233676004","body":{"sequence":7,"sessionId":"22042985004","telephonySessionId":"s-064b8e4aee274bdd98f021ddcaf8a50f","serverId":"10.28.20.109.TAM","eventTime":"2020-02-21T22:06:33.542Z","parties":[{"accountId":"233676004","extensionId":"233676004","id":"p-064b8e4aee274bdd98f021ddcaf8a50f-3","direction":"Inbound","to":{"phoneNumber":"101","name":"Tyler Long","extensionId":"233676004"},"from":{"phoneNumber":"+16504306662"},"status":{"code":"Proceeding","mobilePickupData":{"ccMailboxes":["233676004"],"to":"#34004@sip.devtest.ringcentral.com:5060","sid":"35206415073836","srvLvl":"-149699523","srvLvlExt":"502"},"rcc":false},"missedCall":false,"standAlone":false,"muted":false}],"origin":{"type":"Call"}}}
{"uuid":"3616463071075446811","event":"/restapi/v1.0/account/233676004/extension/233676004/telephony/sessions","timestamp":"2020-02-21T22:06:38.290Z","subscriptionId":"930bf156-f529-4860-8acd-c098ba99e965","ownerId":"233676004","body":{"sequence":8,"sessionId":"22042985004","telephonySessionId":"s-064b8e4aee274bdd98f021ddcaf8a50f","serverId":"10.28.20.109.TAM","eventTime":"2020-02-21T22:06:38.141Z","parties":[{"accountId":"233676004","extensionId":"233676004","id":"p-064b8e4aee274bdd98f021ddcaf8a50f-3","direction":"Inbound","to":{"phoneNumber":"101","name":"Tyler Long","extensionId":"233676004"},"from":{"phoneNumber":"+16504306662"},"status":{"code":"Answered","mobilePickupData":{"ccMailboxes":["233676004"],"to":"#34004@sip.devtest.ringcentral.com:5060","sid":"35206415073836","srvLvl":"-149699523","srvLvlExt":"502"},"rcc":false},"missedCall":false,"standAlone":false,"muted":false}],"origin":{"type":"Call"}}}
{"uuid":"6939921162315230404","event":"/restapi/v1.0/account/233676004/extension/233676004/telephony/sessions","timestamp":"2020-02-21T22:06:44.206Z","subscriptionId":"930bf156-f529-4860-8acd-c098ba99e965","ownerId":"233676004","body":{"sequence":9,"sessionId":"22042985004","telephonySessionId":"s-064b8e4aee274bdd98f021ddcaf8a50f","serverId":"10.28.20.109.TAM","eventTime":"2020-02-21T22:06:44.111Z","parties":[{"accountId":"233676004","extensionId":"233676004","id":"p-064b8e4aee274bdd98f021ddcaf8a50f-3","direction":"Inbound","to":{"phoneNumber":"101","name":"Tyler Long","extensionId":"233676004"},"from":{"phoneNumber":"+16504306662"},"status":{"code":"Disconnected","rcc":false},"missedCall":false,"standAlone":false,"muted":false}],"origin":{"type":"Call"}}}
{"uuid":"3105775963465210318","event":"/restapi/v1.0/account/233676004/telephony/sessions","timestamp":"2020-02-21T22:06:44.217Z","subscriptionId":"930bf156-f529-4860-8acd-c098ba99e965","ownerId":"233676004","body":{"sequence":10,"sessionId":"22042985004","telephonySessionId":"s-064b8e4aee274bdd98f021ddcaf8a50f","serverId":"10.28.20.109.TAM","eventTime":"2020-02-21T22:06:44.125Z","parties":[{"accountId":"233676004","id":"p-064b8e4aee274bdd98f021ddcaf8a50f-1","direction":"Outbound","to":{"phoneNumber":"+15178795131","name":"Tyler Long","extensionId":"233676004"},"from":{"phoneNumber":"+16504306662"},"status":{"code":"Disconnected","rcc":false},"missedCall":false,"standAlone":false,"muted":false}],"origin":{"type":"Call"}}}
```