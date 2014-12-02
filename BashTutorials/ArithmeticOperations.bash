#!/bin/bash
read X

echo $(printf %.3f $(echo $X | bc -l))