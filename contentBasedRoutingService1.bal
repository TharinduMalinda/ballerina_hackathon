package routingServices.samples;

import ballerina.net.http;
import ballerina.lang.messages;
import ballerina.lang.system;
@http:configuration {basePath:"/cbr"}
service<http> contentBasedRouting {

    @http:GET {}
    @http:Path {value:"/route"}
    resource cbrResource (message m) {
    message ma = {};
    
        http:ClientConnector locationEP = create http:ClientConnector("http://localhost:40312/");
        
      //  json jsonMsg = messages:getJsonPayload(m);

        //string nameString;
         message res = http:ClientConnector.get(locationEP, "api/jobs", ma);
        system:println(res);
         json jsonMsg = messages:getJsonPayload(res);
         system:println(jsonMsg);
        // var  nameString, _ = (string)jsonMsg["fisrtName"];

    //var nameString, _ = (string)jsonMsg.JobID;
                //system:println(nameString);

        message response = {};
       //messages:setStringPayload(response, nameString);
        reply response;
    }
    
}



    