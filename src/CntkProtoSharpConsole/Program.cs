using CNTK.Proto;
using CNTK.Proto.Test;

// Examples see https://github.com/microsoft/CNTK/blob/master/PretrainedModels/Image.md
var inputFilePath = @"ResNet20_CIFAR10_CNTK.cntk.model";

var model = Dictionary.Parser.ParseFromFile(inputFilePath);

var data = model.Data;

model.WriteToFile(@"ResNet20_CIFAR10_CNTK_TEST.cntk.model");
model.WriteIndentedJsonToFile(@"ResNet20_CIFAR10_CNTK_TEST.cntk.json");