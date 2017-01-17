﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using JoshuaKearney.Measurements.Parser.Syntax;


//namespace JoshuaKearney.Measurements.Parser.Evaluating {
//    internal class EvaluationVisitor {
//        private IEnumerable<Operator> Operators;
//        private IReadOnlyDictionary<string, IMeasurement> Units;
//        private object lockObj = new object();

//        public bool TryInterpret(
//            AbstractSyntaxTree tree, 
//            IEnumerable<Operator> ops, 
//            IReadOnlyDictionary<string, IMeasurement> units,
//            out IMeasurement success,
//            out ParseException failure) {

//            lock (lockObj) {
//                this.Operators = ops;
//                this.Units = units;

//                return this.Visit(tree, out success, out failure);
//            }
//        }

//        private bool Visit(AbstractSyntaxTree tree, out IMeasurement success, out ParseException failure) {
//            if (tree is BinaryOperatorTree) {
//                return this.VisitBinaryOperator(tree as BinaryOperatorTree, out success, out failure);
//            }
//            else if (tree is IdLeaf) {
//                return this.VisitIdLeaf(tree as IdLeaf, out success, out failure);
//            }
//            else if (tree is NumberLeaf) {
//                return this.VisitNumberLeaf(tree as NumberLeaf, out success, out failure);
//            }
//            else {
//                success = null;
//                failure = ParseException.UnrecognizedSyntaxConstructDiscovered(tree.GetType());
//                return false;
//            }
//        }

//        private bool VisitUrnaryOperator(UrnaryOperatorTree tree, out IMeasurement success, out ParseException failure) {
//            if (this.Visit(tree.Operand, out success, out failure)) {
//                if (Evaluation.ApplyUrnaryOperator(this.Operators, tree.Type, success, out success, out failure)) {
//                    return true;
//                }

//                failure = ParseException.UrnaryOperatorEvaluationFailed(tree.Operand.Token.StringValue, success.ToString());
//                return false;
//            }

//            return false;
//        }

//        private bool VisitBinaryOperator(BinaryOperatorTree tree, out IMeasurement success, out ParseException failure) {
//            IMeasurement first, second;

//            if (this.Visit(tree.LeftOperand,  out first, out failure)) {
//                if (this.Visit(tree.RightOperand, out second, out failure)) {
//                    if (Evaluation.ApplyBinaryOperator(this.Operators, tree.Type, first, second, out success, out failure)) {
//                        return true;
//                    }
//                    else if (tree.Type == BinaryOperatorType.Multiplication || tree.Type == BinaryOperatorType.Addition) {
//                        if (Evaluation.ApplyBinaryOperator(this.Operators, tree.Type, second, first, out success, out failure)) {
//                            return true;
//                        }
//                    }

//                    success = null;
//                    failure = ParseException.BinaryOperatorEvaluationFailed(tree.Token.StringValue, first.ToString(), second.ToString());
//                    return false;
//                }
//            }

//            success = null;
//            return false;
//        }

//        private bool VisitIdLeaf(IdLeaf id, out IMeasurement success, out ParseException failure) {
//            if (!this.Units.ContainsKey(id.Value)) {
//                success = null;
//                failure = ParseException.UndefinedUnitDiscovered(id.Value);
//                return false;
//            }
//            else {
//                success = this.Units[id.Value];
//                failure = null;
//                return true;
//            }
//        }

//        private bool VisitNumberLeaf(NumberLeaf leaf, out IMeasurement success, out ParseException failure) {
//            success = new DoubleMeasurement(leaf.Value);
//            failure = null;
//            return true;
//        }        
//    }
//}